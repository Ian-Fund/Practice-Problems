c class Solution {
	    public IList<IList<int>> Generate(int numRows) {
		            IList<IList<int>> triangle = new List<IList<int>>();
			            
			            if(numRows == 0)
					                return triangle;
				            triangle.Add(new List<int> {1});
					            
					            for (int i = 1; i < numRows; i++){
							                List<int> prev_row = triangle[i-1].ToList();
									            List<int> cur_row = new List <int>();
										                cur_row.Add(1);
												            for (int j = 1; j < i; j++){
														                    cur_row.Add(prev_row[j]+ prev_row[j-1]);
																                }
													                cur_row.Add(1);
															            triangle.Add(cur_row);
																            }
						            return triangle;
							        }
}
