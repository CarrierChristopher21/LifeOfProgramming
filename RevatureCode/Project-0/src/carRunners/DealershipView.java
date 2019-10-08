package carRunners;

import java.util.Scanner;

public class DealershipView {
	
	String answer = "";
    /*  File Links  */
    //  Student Controller
    public DealershipController aController = null;
    //  Program
    DealershipProgramRunner aProgramRunner = new DealershipProgramRunner();
    //  Startup Input
    CarStartupInput aStartupInput = new CarStartupInput();
           

	public DealershipView() {
		super();
	}

	public DealershipView(DealershipController aController) {
		super();
		this.aController = aController;
		this.PrintMenu();
	}

	//  Program                         -       Main Program Itself     -   Runner
    public void PrintMenu()
    {
    	//	Console.OutputEncoding = System.Text.Encoding.Unicode;
		Scanner sIn = new Scanner(System.in);
        //  Program Input
        answer = aStartupInput.GetStartUpInput(answer, sIn);     //  Collecting input from Console

        //  Program Loop
        answer = aProgramRunner.ProgramLoop(answer, sIn);
        
        sIn.close();
    }




        
}   //  End of ConsoleView Class
	
