using System;
using System.Drawing; //для роботи з графікою, кольорами, і т.д.
using System.IO; //для роботи з файлами
using System.Windows.Forms;
using System.Collections.Generic;

namespace GraphDrawSpace
{
    public partial class GraphDraw : Form
    {
        private List<List<PointF>> values; //список списків точок, що є координатами графіків
        private List<string> namesOfGraphs; //список імен графіків
        private List<Pen> graphPens; //список пензлів для малювання графіків
        private float zoombyX;
        private float zoombyY;
        
        public GraphDraw() //конструктор класу GraphDraw
        {
            InitializeComponent();
            values = new List<List<PointF>>();
            namesOfGraphs = new List<string>();
            graphPens = new List<Pen>();
            zoombyX = 1;
            zoombyY = 1;
            pictureBoxCanvas.Paint += PictureBox_Paint;
            KeyDown += Graph_KeyArrows; //обробник подій для натискання клавіш
            KeyPreview = true;
    

            buttonColorBlue.Click += ColorButton_Click;
            buttonColorCrimson.Click += ColorButton_Click;
            buttonColorViolet.Click += ColorButton_Click;
            buttonColorOrange.Click += ColorButton_Click;
            buttonColorRoyalBlue.Click += ColorButton_Click;
            buttonColorLime.Click += ColorButton_Click;
        }

        

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics; 
            DepictGraph(g);
        }

        private void DepictGraph(System.Drawing.Graphics g) //оформлення системи координат
        {
            int width = pictureBoxCanvas.Width;
            int height = pictureBoxCanvas.Height;

            g.Clear(Color.White); //очищення полотна g
            Pen axisPen = new Pen(Color.Black, 1);
            Font font = new Font(FontFamily.GenericSansSerif, 10);
            Font grid = new Font(FontFamily.GenericSansSerif, 9);
            float xCenter = width / 2; // знаходимо центр pictureBox для відображення осей
            float yCenter = height / 2;

            //малювання вісі ординат OY
            g.DrawLine(axisPen, xCenter, 0, xCenter, height);
            g.DrawLine(axisPen, xCenter - 10, 10, xCenter, 0); //малювання стрілок
            g.DrawLine(axisPen, xCenter + 10, 10, xCenter, 0);
            g.DrawString("Y", font, Brushes.DarkBlue, xCenter - 20, 0); //підпис вісі

            //малювання вісі абсцис OX
            g.DrawLine(axisPen, 0, yCenter, width, yCenter); 
            g.DrawLine(axisPen, width - 10, yCenter - 10, width, yCenter); //малювання стрілок
            g.DrawLine(axisPen, width - 10, yCenter + 10, width, yCenter); 
            g.DrawString("X", font, Brushes.DarkBlue, width - 10, yCenter - 20); //підпис вісі
            g.DrawString("0", font, Brushes.DarkBlue, xCenter - 10, yCenter + 2); //підпис центру координат

            // малювання сітки
            float spacingY = (height - 200) / 30;
            float spacingX = (width - 300) / 30;
            Pen linePen = new Pen(Color.Gray, 1);
            int k;
            // Малюємо вертикальні лінії сітки зліва від центру
            k = -1;
            for (float i = xCenter - spacingX; i >= 15; i -= spacingX)
            {
                g.DrawLine(linePen, i, 0, i, height);
                g.DrawString(k.ToString(), grid, Brushes.Black, i - 10, yCenter + 2);
                k--;
            }
            // Малюємо вертикальні лінії сітки справа від центру
            k = 1;
            for (float i = xCenter + spacingX; i <= width - 15; i += spacingX)
            {
                g.DrawLine(linePen, i, 0, i, height);
                g.DrawString(k.ToString(), grid, Brushes.Black, i - 10, yCenter + 2);
                k++;
            }
            // Малюємо горизонтальні лінії сітки вище центру
            k = 1;
            for (float i = yCenter - spacingY; i >= 15; i -= spacingY)
            {
                g.DrawLine(linePen, 0, i, width, i);
                g.DrawString(k.ToString(), grid, Brushes.Black, xCenter - 18, i);
                k++;
            }
            // Малюємо горизонтальні лінії сітки нижче центру
            k = -1;
            for (float i = yCenter + spacingY; i <= height - 15; i += spacingY)
            {
                g.DrawLine(linePen, 0, i, width, i);
                g.DrawString(k.ToString(), grid, Brushes.Black, xCenter - 18, i);
                k--;
            }

            //малювання графіків
            for (int j = 0; j < values.Count; j++)
            {
                List<PointF> data = values[j];
                Pen pen = graphPens[j];
                for (int i = 1; i < data.Count; i++)
                {
                    PointF p1 = data[i - 1];
                    PointF p2 = data[i];
                    if (!p1.IsEmpty && !p2.IsEmpty) //перевіра чи точки p1 та p2 не є пустими
                    {
                        float x1 = xCenter + p1.X * spacingX * zoombyX;
                        float y1 = yCenter - p1.Y * spacingY * zoombyY;
                        float x2 = xCenter + p2.X * spacingX * zoombyX;
                        float y2 = yCenter - p2.Y * spacingY * zoombyY;
                        g.DrawLine(pen, x1, y1, x2, y2); //відмальовка
                    }
                }
            }


        }

        private void Graph_KeyArrows(object sender, KeyEventArgs e) //метод для стиснення/розтягнення графіка відносно осі абсцис/ординат
        {
            switch (e.KeyCode) //перевіряємо натиснуту клавішу
            {
                case Keys.Right: // ->
                    zoombyX += 0.1f;
                    break;
                case Keys.Left: // <-
                    zoombyX -= 0.1f;
                    zoombyX = Math.Max(0.1f, zoombyX);
                    break;
                case Keys.Up: // ↑
                    zoombyY += 0.1f;
                    break;
                case Keys.Down: // ↓
                    zoombyY -= 0.1f;
                    zoombyY = Math.Max(0.1f, zoombyY);
                    break;
                default:
                    return;
            }
            pictureBoxCanvas.Invalidate(); //перемальовування
        }

        private void ColorButton_Click(object sender, EventArgs e) //оптимізація вибору кольору
        {
            if (values.Count > 0)
            {
                Color pens = ((Button)sender).BackColor;
                graphPens.Add(new Pen(pens, 1));
            }
            else
            {
                MessageBox.Show("There is no graph to which the color can be attributed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<PointF> LoadFile(string filename) //зчитування файлу, метод повертає список точок графіка
        {
            List<PointF> data = new List<PointF>();
            try //try-catch для відслідковування помилок
            {
                using (StreamReader reader = new StreamReader(filename)) //відкриваємо файл для читання і створюємо об'єкт StreamReader
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // читання файл рядок за рядком до кінця файлу
                    {
                        string[] datesforgraph = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Розбиває рядок на частини за пробілами і зберігає їх в масив datesforgraph
                        if (datesforgraph.Length == 2)//Перевіряє, чи містить рядок рівно два елементи.
                        {
                            if (datesforgraph[1].Equals("empty"))//Перевіряє, чи другий елемент масиву є рядком "empty"
                            {
                                data.Add(PointF.Empty);//додаємо порожгю точку до списку data
                            }
                            else //Якщо другий елемент не є "empty"
                            {
                                if (float.TryParse(datesforgraph[0], out float x) && float.TryParse(datesforgraph[1], out float y)) //TryParse - спроба конвертувати, Спробує перетворити обидва елементи масиву на числа типу float
                                {
                                    data.Add(new PointF(x, y));//Якщо перетворення успішне, додає нову точку з координатами x і y до списку data
                                }
                            }
                        }
                    }
                }
                return data;//повертає список data
            }
            catch (Exception ex) // якщо виключення, то перехоплює її та зберігє в ex
            {
                MessageBox.Show("Error reading data file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //показує повідомлення з помилкою
                return null;//Повертає null у випадку помилки.
            }
        }

        

        private void OpenFileButton_Click(object sender, EventArgs e) 
        {

            using (var openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.InitialDirectory = "D:\\Document1\\UNIVERSITY\\4\\Practice\\PrepData\\resources\\"; //початкову директорію для діалогового вікна.
                openFileDialog.Filter = "Text Files|*.txt"; //Встановлює фільтр, щоб показувати тільки текстові файли (.txt)
                openFileDialog.RestoreDirectory = true; //Встановлює прапорець, який вказує, що діалогове вікно повинно запам'ятовувати останню відкриту директорію.

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    List<PointF> data = LoadFile(filename);
                    if (data != null)
                    {
                        values.Add(data);
                    }
                }
            }
        }


        private void buttonSaveNameGraph_Click(object sender, EventArgs e) 
        {
            string name = NameOfGraph.Text; 
            if (name != "Name of the graph")//Перевіряє, чи текст у полі не є стандартним значенням "Name of the graph". Якщо це так, то користувач не ввів нове ім'я
            {
                int flag = 0; 
                for (int i = 0; i < namesOfGraphs.Count; i++) //Проходить через весь список namesOfGraphs. Якщо введене ім'я вже існує в списку, збільшує значення flag на 1 і виходить з циклу
                {
                    if (namesOfGraphs[i] == name)//
                    {
                        flag++; break;
                    }
                }
                if (flag == 0)
                {
                    namesOfGraphs.Add(name);
                    comboBoxBuiltGraphs.Items.Add(name); // Добавляем имя графика в ComboBox
                }
                else
                {
                    MessageBox.Show("The name already exists.", "Wrong name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" You need to set the name for your function.", "Wrong name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AddDepictedGraphs()
        {
            groupOfDepictedGraphs.Controls.Clear();
            int vertical = 20;//Встановлює початковий вертикальний відступ для розміщення елементів управління.

            FlowLayoutPanel positionofLegend = new FlowLayoutPanel();//Створює новий екземпляр FlowLayoutPanel для розміщення легенд
            positionofLegend.FlowDirection = FlowDirection.LeftToRight;//Встановлює напрямок розташування елементів управління всередині FlowLayoutPanel зліва направо.
            positionofLegend.AutoSize = true;
            positionofLegend.AutoSizeMode = AutoSizeMode.GrowAndShrink; 
            positionofLegend.Location = new Point(10, vertical);//встановлює початкове положення FlowLayoutPanel на формі (відступ 10 пікселів зліва і vertical пікселів зверху

            for (int i = 0; i < namesOfGraphs.Count; i++)//Цикл проходить через всі імена графіків в списку namesOfGraphs
            {
                string graphName = namesOfGraphs[i];//Отримує ім'я графіка з namesOfGraphs 
                Pen graphPen = graphPens[i];//та відповідне перо з graphPens

                Label Legend = new Label();//Створює новий екземпляр Label
                Legend.AutoSize = true;
                Legend.Width = 60;
                Legend.Height = 4;
                Legend.Margin = new Padding(0, 0, 20, 0); // простір між легендами
                Legend.Text = "  - " + graphName;
                Legend.ForeColor = Color.Black;

                Legend.Paint += (sender, e) => 
                {
                    using (Pen linePen = new Pen(graphPen.Color))
                    {
                        int lineY = Legend.Height / 2;
                        e.Graphics.DrawLine(linePen, 0, lineY, 7, lineY);
                    }
                };
                positionofLegend.Controls.Add(Legend);
            }

            groupOfDepictedGraphs.Controls.Add(positionofLegend);
        }

        private void BuildGraphButton_Click(object sender, EventArgs e)
        {
            if (values.Count > 0)
            {
                pictureBoxCanvas.Invalidate();
                AddDepictedGraphs();
            }
            else
            {
                MessageBox.Show("Have no data to build", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            values.Clear();
            namesOfGraphs.Clear();
            graphPens.Clear();
            groupOfDepictedGraphs.Controls.Clear();
            pictureBoxCanvas.Invalidate();
            comboBoxBuiltGraphs.Items.Clear();
        }

        private void buttonMoveGraph_Click(object sender, EventArgs e)
        {
            if (values.Count > 0)
            {
                string graph = comboBoxBuiltGraphs.Text;
                string movingX = textBoxMoveOX.Text;
                string movingY = textBoxMoveOY.Text;
                if (!string.IsNullOrEmpty(graph) && !string.IsNullOrEmpty(movingX) && !string.IsNullOrEmpty(movingY))
                {
                    int selected = -1;

                    for (int i = 0; i < namesOfGraphs.Count; i++)
                    {
                        if (graph == namesOfGraphs[i])
                        {
                            selected = i;
                            break;
                        }
                    }

                    if (selected == -1)
                    {
                        MessageBox.Show("You haven't chosen the graph to move.", "No function chosen");
                    }
                    else
                    {
                        float x = float.Parse(movingX); //конвертація у тип float
                        float y = float.Parse(movingY);

                        for (int i = 0; i < values[selected].Count; i++)
                        {
                            values[selected][i] = new PointF(values[selected][i].X + x, values[selected][i].Y + y);
                        }
                        pictureBoxCanvas.Invalidate();
                    }
                }
                else
                {
                    MessageBox.Show("You need to set OX and OY.", "No coordinates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no graph to which the title can be attributed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            DepictGraph(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
