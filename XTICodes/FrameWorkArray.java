import java.util.ArrayList;

public class FrameWorkArray{
	
	public static void main(String[] args){
		
		ArrayList<String> cores = new ArrayList<>();
		cores.add("Branco");
		cores.add(0, "Vermelho");
		cores.add("Amarelo");
		cores.add("Azul");
		System.out.println(cores.toString());
		System.out.println("Tamanho do Array : "+cores.size());
		System.out.println("Elemento no Indice 2: "+cores.get(2));
		System.out.println("Pesquisa de indice: "+cores.indexOf("Branco"));
		cores.remove("Branco");
		System.out.println(cores.toString());
		System.out.println("Tem Amarelo? "+cores.contains("Amarelo"));
		System.out.println("Tem Cinza? "+cores.contains("Cinza"));
	}
}