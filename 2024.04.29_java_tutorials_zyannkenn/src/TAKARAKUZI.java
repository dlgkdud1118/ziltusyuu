import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;

public class TAKARAKUZI {

	private Scanner scanner = new Scanner(System.in);
	
	private ArrayList<int[]> numbersList = new ArrayList<>();
	private ArrayList<NumberSet> numbersList2 = new ArrayList<>();
	
	public void doStart() { 
		
		String selection = "";
		int[] numbers = new int[6];
		int sum = 0, average = 0;
		
		MainLoop:
		while (true) {
			
			selection = selectMenu();
			System.out.println();
			
			switch(selection) {
			case "1":
				do {
					
					numbers = selectBasicNumbers();
					
					average = calculateMean(numbers);
					
				} while (average < 20 || average > 26);
				
				showNumbers(numbers, average);
				
				numbersList.add(numbers);
				
				NumberSet set = new NumberSet(0, numbers, new Date());
				numbersList2.add(set);
				
				break;
			
			case "2":
				System.out.println("[当選予想目録]");
				
				for (NumberSet numberSet : numbersList2) {
					System.out.println(numberSet);
				}
				break;
				
			case "9":
				System.out.println("幸運を祈ります···");
				break MainLoop;
			default:
				System.out.println("サポートしていないコマンドです。");
				break;
			}
		}
		
	}
	
	public String selectMenu() {
		System.out.println("\n********************************************");
		System.out.println("*	1. 番号抜き								*");
		System.out.println("*	2. リストを見る							*");
		System.out.println("*	9. 終了									*");
		System.out.println("********************************************");
		
		System.out.println("ご希望のタスク番号を入力してください ：	");
		String selection = scanner.nextLine();
		return selection;
	}
	
	public int[] selectBasicNumbers() {
		int[] numbers = new int[6];
		for (int i = 0; i < 6; i = i + 1) {
			numbers[i] = (int) (Math.random() * 45) +1;
			for (int j = 0; j < i; j = j + 1) {
				if(numbers[i] == numbers[j]) {
					i = -1;
				}
			}
		}
		return numbers;
	}
	
	public int calculateMean(int[] numbers) {
		int sum = 0;
		for (int i = 0; i < 6; i = i + 1) {
			sum = sum + numbers[i];
		}
		int average = sum / 6;
		
		return average;
	}
	
	public void showNumbers(int[] numbers, int average) {
		System.out.print("SELECTED NUMBERS : ");
		for (int i = 0; i < 6; i = i + 1) {
			System.out.printf("[%2d]", numbers[i]);
		}
		
	}
	
	public static void main(String[] args) {
		
		TAKARAKUZI takarakuzi = new TAKARAKUZI();
		takarakuzi.doStart();
		
		
		
		
	}

}
