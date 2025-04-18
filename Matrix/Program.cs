﻿// Вариант 3: Заполнение матрицы змейкой по диагонали
//      Задание: Напишите программу, которая заполняет двумерный массив размером n x m числами от
//      1 до n * m змейкой по диагонали. Это означает, что заполнение должно идти по диагоналям,
//      начиная с верхнего левого угла и двигаясь вправо-вниз.
//      Пример: Для n = 3 и m = 4 массив должен выглядеть так:
//      1 2 6 7
//      3 5 8 11
//      4 9 10 12

using Matrix;

int row = 5;
int col = 5;

var matrix = new DiagonalSnake(row, col);
matrix.ShowMatrix();