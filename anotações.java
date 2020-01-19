import java.time.LocalDate;
import java.time.Month;
import java.time.Period;

public class APP {
	public static void main(String[] args) {
	LocalDate today = LocalDate.now();                          //Data Atual
	LocalDate birthday = LocalDate.of(1995, Month.NOVEMBER, 7);  //Data do depósito
	
	Period p = Period.between(birthday, today);		
	
	System.out.println(p.getDays());
	System.out.println(p.getYears());
	System.out.println(p.toTotalMonths()); //Retornando a quantidade de meses com a precisão correta.
		
	String date = "2016-08-16";

	//default, ISO_LOCAL_DATE
        LocalDate localDate = LocalDate.parse(date);

        System.out.println(localDate);
		
	//Conferir dados: https://www.calendario-365.com.br/calcular/19-08-2018_19-01-2020.html 
	}	
}
