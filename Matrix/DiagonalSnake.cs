namespace Matrix;

public class DiagonalSnake
{
    public int Row{get;}
    public int Col{get;}
    int [,] _matrix;
    public DiagonalSnake (int row, int col)
    {
        Row = row;
        Col = col;
        _matrix = new int[Row, Col];
        int current = 1;

        for (int sum = 0; sum < Row + Col - 1; sum++)
        {
            if (sum % 2 == 0)
            {
                // Движение снизу вверх (чётные диагонали)
                int rowIdx = Math.Min(sum, Row - 1);
                int colIdx = sum - rowIdx;

                while (rowIdx >= 0 && colIdx < col)
                {
                    _matrix[rowIdx, colIdx] = current++;
                    rowIdx--;
                    colIdx++;
                }
            }
            else
            {
                // Движение сверху вниз (нечётные диагонали)
                int colIdx = Math.Min(sum, Col - 1);
                int rowIdx = sum - colIdx;

                while (colIdx >= 0 && rowIdx < Row)
                {
                    _matrix[rowIdx, colIdx] = current++;
                    rowIdx++;
                    colIdx--;
                }
            }
        }
    }

    // Вывод матрицы
    public void ShowMatrix()
    {
        for (int i = 0; i < Row; i++)
        {
            for (int j = 0; j < Col; j++)
            {
                Console.Write(_matrix[i, j]+"\t");
            }
            Console.WriteLine();
        }
    }
}