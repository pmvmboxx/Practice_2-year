#include <Windows.h>
#include <iostream>
#include <fstream>
#include <sstream>
#include <iomanip>
#include <cmath>
#include <algorithm>

using namespace std;

double Task16Function(double x) { //���������� ������� �������� �� ������� 16
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
    string directoryway = "D:/Document1/UNIVERSITY/4/Practice/PrepData/resources//"; //���� �� ��������, �� ������ ���������� ���� 
    string name;
    ofstream outfile;
    do {
        cout << "Enter the file name to write the results to: ";
        cin >> name;
        outfile.open(directoryway + name); //������ ������� ���� ��� ������ � ��� ��������
        if (!outfile.is_open()) {
            cerr << "Error. The file couldn't be opened." << endl;
        }
    } while (!outfile.is_open());

    stringstream buffer; //����� ��� ����������� ���������� ����� ������� � ����

    double x = min, y; //���� ��� x �� y
    while (x <= max) {
        y = Task16Function(x);
            if (isnan(y) || isinf(y)) { //�������� y ������ ��������/������������
                buffer << x << " empty" << endl;
            }
            else {
                ostringstream oss;
                oss << x << " " << setprecision(7) << y;//�������� x �� y � ������� 7 ����� ���� ����
                string result = oss.str(); 
                replace(result.begin(), result.end(), '.', ','); //��������� ����� result � �������� ������ �� ���� ��� ��������� ������� � �������� �����
                buffer << result << endl;
            }
            x += step;
    }
    outfile << buffer.str(); //���� buffer ���������� � ����
    outfile.close();
    cout << "Results written to the file." << endl;
}

int main()
{
    double min, max, step;
    cout << "Enter min, max, step: ";
    cin >> min >> max >> step;

    while (min == 0 && max == 0) { //�������� mins, max �� ������ 0
        cerr << "Error. Range can't be equal zero." << endl;
        cout << "Enter min and max: " << endl;
        cin >> min >> max;
    }
    if(min > max) { //�������� �� �������� �������� min, max
        swap(min, max);
    }
    while (min == max) { //�������� �� �������� ��������
        cerr << "MIN must be less than MAX value.";
        cout << "Enter new min and max: " << endl;
        cin >> min >> max;
    }
    while ((max - min) < step || step == 0) { //�������� �� ���������� ����� (����� �� �������, �� ������� 0)
        cout << "Step must be less than the given range. And it can't equal zero. Enter new step: ";
        cin >> step;
    }

    WriteToFile(min, max, step);
    system("pause");
    return 0;

}

