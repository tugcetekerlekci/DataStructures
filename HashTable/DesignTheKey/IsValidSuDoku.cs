/**Determine if a 9x9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the 9 3x3 sub-boxes of the grid must contain the digits 1-9 without repetition.

A partially filled sudoku which is valid.

The Sudoku board could be partially filled, where empty cells are filled with the character '.'.

Example 1:

Input:
[
  ["5","3",".",".","7",".",".",".","."],
  ["6",".",".","1","9","5",".",".","."],
  [".","9","8",".",".",".",".","6","."],
  ["8",".",".",".","6",".",".",".","3"],
  ["4",".",".","8",".","3",".",".","1"],
  ["7",".",".",".","2",".",".",".","6"],
  [".","6",".",".",".",".","2","8","."],
  [".",".",".","4","1","9",".",".","5"],
  [".",".",".",".","8",".",".","7","9"]
]
Output: true
Example 2:

Input:
[
  ["8","3",".",".","7",".",".",".","."],
  ["6",".",".","1","9","5",".",".","."],
  [".","9","8",".",".",".",".","6","."],
  ["8",".",".",".","6",".",".",".","3"],
  ["4",".",".","8",".","3",".",".","1"],
  ["7",".",".",".","2",".",".",".","6"],
  [".","6",".",".",".",".","2","8","."],
  [".",".",".","4","1","9",".",".","5"],
  [".",".",".",".","8",".",".","7","9"]
]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being 
    modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
The given board contain only digits 1-9 and the character '.'.
The given board size is always 9x9.**/
public class Solution {
    public Solution()
    {
        SetForRanges();
    }
	public List<Tuple<int,int>>  RowRanges = new List<Tuple<int,int>>(); 
	public List<Tuple<int,int>>  ColumnRanges = new List<Tuple<int,int>>();
	public bool ValidateCube(Tuple<int,int> columnRange, Tuple<int,int> rowRange,char [,] board)
	{
		HashSet<int> set = new HashSet<int>(); 
		for (int j=columnRange.Item1; j< columnRange.Item2; j++)
		{
			for (int i= rowRange.Item1;i<rowRange.Item2;i++)
			{
				if (board[i,j] != '.' && !set.Add(board[i,j]))
				{
					return false; 
				}
			}
		}
		return true;
	}
	
	public void SetForRanges()
	{
		var rowRange=  new Tuple<int, int>(0,3);
		var columnRange = new Tuple<int,int>(0,3);
		
		for (int j=0;j<9;j++)
		{
			var item1 = rowRange.Item1;
			var item2 = rowRange.Item2;
			item1 = item1 + (j%3)*3 ;
			item2 = item2 + (j%3)*3;
			RowRanges.Add(new Tuple<int,int>(item1,item2));	
		}
		
		
		ColumnRanges.Add(new Tuple<int,int>(0,3));	
		ColumnRanges.Add(new Tuple<int,int>(0,3));
		ColumnRanges.Add(new Tuple<int,int>(0,3));
		
		ColumnRanges.Add(new Tuple<int,int>(3,6));	
		ColumnRanges.Add(new Tuple<int,int>(3,6));
		ColumnRanges.Add(new Tuple<int,int>(3,6));
		
		ColumnRanges.Add(new Tuple<int,int>(6,9));	
		ColumnRanges.Add(new Tuple<int,int>(6,9));
		ColumnRanges.Add(new Tuple<int,int>(6,9));
	}
	
	public bool ValidateCubes (char [,] board)
	{
		for(int i=0; i<RowRanges.Count();i++)
		{
			if(!ValidateCube(ColumnRanges[i],RowRanges[i], board))
			{
				return false;
			}
		}
		return true; 
	}
	
	public bool ValidateColumns(char[,] board)
	{
		HashSet<int> set = new HashSet<int>(); 
		for (int i=0;i<9;i++)
		{
			for (int j=0; j<9;j++)
			{
				if (board[i,j] != '.' && !set.Add(board[i,j]))
				{
					return false; 
				}
			}
			set.Clear();
		}
		
		return true;
	}
	
	public bool ValidateRows(char[,] board)
	{
		HashSet<int> set = new HashSet<int>(); 
		for (int i=0;i<9;i++)
		{
			for (int j=0; j<9;j++)
			{
				//Console.WriteLine("{0},{1}",j.ToString(), i.ToString());
				//Console.WriteLine(set);
				//Console.WriteLine("element is {0}",board[j,i]);
				if (board[j,i] != '.' && !set.Add(board[j,i]))
				{
					return false; 
				}
			}
			//Console.WriteLine("==========");
			set.Clear();
		}
		
		return true;
	}
    public bool IsValidSudoku(char[,] board) {
		Console.WriteLine("cubes {0}",ValidateCubes(board));
		Console.WriteLine("rows {0}",ValidateRows(board));
		Console.WriteLine("columns {0}", ValidateColumns(board));
		return ValidateCubes(board) && ValidateRows(board) && ValidateColumns(board);
    }
}
