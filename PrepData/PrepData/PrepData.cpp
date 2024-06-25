#include <Windows.h>
#include <iostream>
#include <fstream>
#include <sstream>
#include <iomanip>
#include <cmath>
#include <algorithm>

using namespace std;

double Task16Function(double x) { //обчислення функції відповідно до Варіанту 16
    double func;
    if (x > -4 && x < -2) {
        func = 6 * x - 2 * (1/tan(0.7 * x)) + (1 / (2 * x + 4)) * log(abs(cos(2 * x)));
    }
    else if(x > 3 && x<= 5){
        func = sqrt(x);
    }
    else {
        func = x + 4;
    }
    return func;
}

void WriteToFile(double min, double max, double step) {
    string directoryway = "D:/Document1/UNIVERSITY/4/Practice/PrepData/resources//"; //шлях до директорії, де будуть зберігатися файл 
    string name;
    ofstream outfile;
    do {
        cout << "Enter the file name to write the results to: ";
        cin >> name;
        outfile.open(directoryway + name); //спроба відкрити файл для запису у цій директорії
        if (!outfile.is_open()) {
            cerr << "Error. The file couldn't be opened." << endl;
        }
    } while (!outfile.is_open());

    stringstream buffer; //буфер для накопичення результатів перед записом у файл

    double x = min, y; //змінні для x та y
    while (x <= max) {
        y = Task16Function(x);
            if (isnan(y) || isinf(y)) { //перевірка y недійсні значення/нескінченність
                buffer << x << " empty" << endl;
            }
            else {
                ostringstream oss;
                oss << x << " " << setprecision(7) << y;//записуємо x та y з точністю 7 знаків після коми
                string result = oss.str(); 
                replace(result.begin(), result.end(), '.', ','); //проходимо увесь result і замінюємо крапки на коми для уникнення проблем з читанням чисел
                buffer << result << endl;
            }
            x += step;
    }
    outfile << buffer.str(); //зміст buffer записується у файл
    outfile.close();
    cout << "Results written to the file." << endl;
}

int main()
{
    double min, max, step;
    cout << "Enter min, max, step: ";
    cin >> min >> max >> step;

    while (min == 0 && max == 0) { //перевірка mins, max на рівність 0
        cerr << "Error. Range can't be equal zero." << endl;
        cout << "Enter min and max: " << endl;
        cin >> min >> max;
    }
    if(min > max) { //перевірка на корректні значення min, max
        swap(min, max);
    }
    while (min == max) { //перевірка на наявність діапазону
        cerr << "MIN must be less than MAX value.";
        cout << "Enter new min and max: " << endl;
        cin >> min >> max;
    }
    while ((max - min) < step || step == 0) { //перевірка на корректнісь кроку (менше за діапазон, не дорівнює 0)
        cout << "Step must be less than the given range. And it can't equal zero. Enter new step: ";
        cin >> step;
    }

    WriteToFile(min, max, step);
    system("pause");
    return 0;

}

