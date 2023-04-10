// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double x1, x2, y1, y2, sabit1, sabit2,detKatsayilar,detX,detY;

Console.WriteLine("1. denklemin sırasıyla x,y katsayılarını ve sabitini giriniz");
x1=Convert.ToDouble(Console.ReadLine());
y1=Convert.ToDouble(Console.ReadLine());    
sabit1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("2. denklemin sırasıyla x,y katsayılarını ve sabitini giriniz");
x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());
sabit2 = Convert.ToDouble(Console.ReadLine());

detKatsayilar = x1 * y2 - y1 * x2;
detX = sabit1*y2- sabit2*y1;
detY = x1 * sabit2 - sabit1 * x2;

Console.WriteLine("x: "+detX/detKatsayilar + " y: "+detY/detKatsayilar);

