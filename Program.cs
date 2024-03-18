Console.Write("Digite um número a fim de encontrá-lo em determinado intervalo: ");
double entrada = Convert.ToDouble(Console.ReadLine());

if(entrada >= 0 && entrada <= 25) {
    Console.WriteLine("\nIntervalo: [0,25]");
}

else if(entrada > 25 && entrada <= 50) {
    Console.WriteLine("\nIntervalo: (25,50]");
}

else if(entrada > 50 && entrada <= 75) {
    Console.WriteLine("\nIntervalo: [50,75]");
}

else if(entrada > 75 && entrada <= 100) {
    Console.WriteLine("\nIntervalo: (75,100]");
}

else {
    Console.WriteLine("Fora de intervalo");
}