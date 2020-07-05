
public class Solution
{
  public int[][] rotate(int[][] matrix)
  {
    int size = matrix.Length -1;
    for(int layer = 0; layer < matrix.Length/2; layer++){
      for (int i = layer; i < size - layer; i++ ){
        int top = matrix[layer][i];
        int right = matrix[i][size-layer];
        int bottom = matrix[size-layer][size-i];
        int left = matrix[size-i][layer];
        
        matrix[layer][i] = left;
        matrix[i][size-layer] = top;
        matrix[size-layer][size-i] = right;
        matrix[size-i][layer] = bottom;
      }
    }
    return matrix;
  }
}

