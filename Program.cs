/* Pirma ********************************************/

//Console.WriteLine("Jusu vardas: ");
//string vardas = Console.ReadLine();
//Console.WriteLine("Jusų pavarde: ");
//string pavarde = Console.ReadLine();
//Console.WriteLine("Gimimo metai: ");
//int gimimo_metai = int.Parse(Console.ReadLine());
//int sie_metai = 2024;

//int amzius = sie_metai - gimimo_metai;

//Console.WriteLine("Aš esu " + vardas + " " + pavarde + ". " + "Man yra " + amzius + " metai.");

/* Antra ********************************************/

//Random randomGenerator = new Random();
//int kintamasis = randomGenerator.Next(0, 4);
//int kintamasis2 = randomGenerator.Next(0, 4);
//if (kintamasis <= kintamasis2 && kintamasis != 0)
//{
//    Console.WriteLine((ushort)kintamasis2 / kintamasis);
//}
//else if (kintamasis2 <= kintamasis && kintamasis2 != 0)
//{
//    Console.WriteLine((ushort)kintamasis / kintamasis2);
//}
//else
//{
//    Console.WriteLine("Vaje, kažkas neišėjo");
//}

/* Trecia ********************************************/

//Random randomGenerator = new Random();
//int kintamasis3 = randomGenerator.Next(0, 25);
//Console.WriteLine(kintamasis3);
//int kintamasis4 = randomGenerator.Next(0, 25);
//Console.WriteLine(kintamasis4);
//int kintamasis5 = randomGenerator.Next(0, 25);
//Console.WriteLine(kintamasis5);

//Console.WriteLine((float)(kintamasis3 + kintamasis4 + kintamasis5) / 3);

/* Ketvirta ********************************************/

//Random randomGenerator = new Random();
//int a = randomGenerator.Next(1, 10);
//Console.WriteLine(a);
//int b = randomGenerator.Next(1, 10);
//Console.WriteLine(b);
//int c = randomGenerator.Next(1, 10);
//Console.WriteLine(c);

//if (a + b > c || a + c > b || b + c > a)
//{
//    Console.WriteLine("Trikampis tikriausiai susidarytų - nesuprantu Pitagoro teoremos");
//}

//else
//{
//    Console.WriteLine("Trikampis nesusidarytų");
//}

/* penkta ********************************************/

//Random randomGenerator = new Random();
//int skaicius1 = randomGenerator.Next(0, 2);
//int skaicius2 = randomGenerator.Next(0, 2);
//int skaicius3 = randomGenerator.Next(0, 2);
//int skaicius4 = randomGenerator.Next(0, 2);
//int nuliai = 0;
//int vienetai = 0;
//int dvejetai = 0;

//Console.WriteLine(skaicius1 + " " + skaicius2 + " " + skaicius3 + " " + skaicius4);

//if (skaicius1 == 0)
//{
//    nuliai++; 
//     }
//else if (skaicius1 == 1)
//{
//    vienetai++;
//}
//else if (skaicius1 == 2)
//{
//    dvejetai++;
//}
//if (skaicius2 == 0)
//{
//    nuliai++;
//}
//else if (skaicius2 == 1)
//{
//    vienetai++;
//}
//else if (skaicius2 == 2)
//{
//    dvejetai++;
//}
//if (skaicius3 == 0)
//{
//    nuliai++;
//}
//else if (skaicius3 == 1)
//{
//    vienetai++;
//}
//else if (skaicius3 == 2)
//{
//    dvejetai++;
//}
//if (skaicius4 == 0)
//{
//    nuliai++;
//}
//else if (skaicius4 == 1)
//{
//    vienetai++;
//}
//else if (skaicius4 == 2)
//{
//    dvejetai++;
//}

//Console.WriteLine("Nulių yra: " + nuliai);
//Console.WriteLine("Vienetų yra: " + vienetai);
//Console.WriteLine("Dvejetų yra: " + dvejetai);

/* sesta ********************************************/

//Random randomGenerator = new Random();
//int number1 = randomGenerator.Next(-10, 10);
//int number2 = randomGenerator.Next(-10, 10);
//int number3 = randomGenerator.Next(-10, 10);
//int number4 = randomGenerator.Next(-10, 10);

//if (number1 < 0)
//{
//    Console.WriteLine("[" + number1 + "]");
//}
//else if (number1 == 0)
//            {
//    Console.WriteLine("(" + number1 + ")");
//}
//else if (number1 > 0)
//{
//    Console.WriteLine("{" + number1 + "}");
//}

//if (number2 < 0)
//{
//    Console.WriteLine("[" + number2 + "]");
//}
//else if (number2 == 0)
//{
//    Console.WriteLine("(" + number2 + ")");
//}
//else if (number2 > 0)
//{
//    Console.WriteLine("{" + number2 + "}");
//}

//if (number3 < 0)
//{
//    Console.WriteLine("[" + number3 + "]");
//}
//else if (number3 == 0)
//{
//    Console.WriteLine("(" + number3 + ")");
//}
//else if (number3 > 0)
//{
//    Console.WriteLine("{" + number3 + "}");
//}

//if (number4 < 0)
//{
//    Console.WriteLine("[" + number4 + "]");
//}
//else if (number4 == 0)
//{
//    Console.WriteLine("(" + number4 + ")");
//}
//else if (number4 > 0)
//{
//    Console.WriteLine("{" + number4 + "}");
//}

///* Septinta ********************************************/

//Random randomGenerator = new Random();
//int zvakes = randomGenerator.Next(5, 3000);
//var nuolaida = 0;

//if (zvakes > 1000 && zvakes < 2000)
//{
//    nuolaida = zvakes * 3 / 100;
//}
//else if (zvakes > 2000)
//{
//    nuolaida = zvakes * 4 / 100;
//}

//Console.WriteLine("Užsakyta žvakių: " + zvakes);
//Console.WriteLine("Jų kaina: " + (zvakes - nuolaida) + " Eur");

///* Astunta ********************************************/

//Random randomGenerator = new Random();
//int pirmas = randomGenerator.Next(0, 100);
//int antras = randomGenerator.Next(0, 100);
//int trecias = randomGenerator.Next(0, 100);

//Console.WriteLine("Paprastas metodas: " + (pirmas + antras + trecias) / 3);

//if (pirmas > 10 && pirmas < 90 && antras > 10 && antras < 90 && trecias > 10 && trecias < 90)
//{
//    Console.WriteLine("Atmetus nereikalingus skaicius: " + (pirmas + antras + trecias) / 3);
//}
//else
//{
//    Console.WriteLine("Skaičiai netinkami ypatingam metodui");
//}
