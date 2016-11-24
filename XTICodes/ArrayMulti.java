public class ArrayMulti{

	public static void main(String[] args){
		
		String[] uma = {"Ricardo", "Sandra", "Gabriel"};
		String[][] duas =
		{
			{"Ricardo","M","DF"},
			{"Sandra","F","MG"}		
		};
		System.out.println(duas[0][0]);
		System.out.println(duas[1][0]);
		
		duas[1][0] = "Gabriel";
		System.out.println(duas[1][0]);
	}
}