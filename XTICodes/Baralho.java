import java.util.Random;

public class Baralho{
	
	public static void main(String[] args){
		
		String[] faces = {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};
		String[] naipes = {"Espadas","Ouros","Paus","Copas"};
		
		Random r = new Random();
		
		String face = faces[r.nextInt(faces.length)];
		String naipe = naipes[r.nextInt(naipes.length)];
		
		String carta = face+ " " +naipe;
		System.out.println(carta);
	}
}