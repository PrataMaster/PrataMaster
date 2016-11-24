import java.util.Arrays;

public class ArraySimples{

	public static void main(String[] args){
		
		int[] impares = new int[5];
		impares[0]= 1;
		impares[1]= 3;
		impares[2]= 5;
		impares[3]= 7;
		impares[4]= 9;
		
		String[] paises = {"Brasil", "Russia", "India", "China"};
		System.out.println(Arrays.toString(paises));
		
		//Pesquisa		
		int position = Arrays.binarySearch(paises, "Russia");
		System.out.println(position);
		
		//Ordenação
		
		Arrays.sort(paises, 0, paises.length);
		System.out.println(Arrays.toString(paises));
		
		Double[] valores = {21.12, 32.12};
		System.out.println(valores[0].doubleValue());
	}
}