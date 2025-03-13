namespace Lab2Charp
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            void task1(){

                Console.WriteLine("Enter Value:");
                double value = Convert.ToDouble(Console.ReadLine());

                Console.Write("1.1D array\n2.2D array\nChoose:");
                byte choice = Convert.ToByte(Console.ReadLine());

                if(choice == 1){

                    Console.WriteLine("Enter Size:");
                    int size = Convert.ToInt32(Console.ReadLine());
                    double[] Arr = new double[size];


                    for (int i = 0 ; i < size ; i++){
                        Console.Write("Arr["+i+"]=");
                        Arr[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    for(int i = 0; i < size; i++){
                        if(Arr[i] < value) Arr[i] = value ; 
                    }

                    for(int i = 0; i < size;i++){
                        Console.Write(Arr[i]+ " ");
                    }
                }
                else if(choice == 2){
                    Console.WriteLine("Enter Size(NxM)");
                    Console.Write("N:");
                    int N = Convert.ToInt32(Console.ReadLine());
                    Console.Write("M:");
                    int M = Convert.ToInt32(Console.ReadLine());

                    double[,] Arr = new double[N,M];

                    for(int i = 0;i<N;i++){
                        for(int j = 0; j<M;j++){
                            Console.Write("Arr["+i+" "+j+"]=");
                            Arr[i,j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    for(int i = 0; i<N;i++){
                        for(int j = 0;j<M;j++){
                            if(Arr[i,j] < value) Arr[i,j] = value;
                        }
                    }

                    for(int i = 0; i<N;i++){
                        for(int j = 0;j<M;j++){
                            Console.Write(Arr[i,j] + " ");
                        }
                        Console.Write("\n");
                    }


                }
                else{
                    Console.WriteLine("Valid number!");
                }
            }
            void task2(){
                Console.WriteLine("Enter Size:");
                int size = Convert.ToInt32(Console.ReadLine());
                double[] Arr = new double[size];


                for (int i = 0 ; i < size ; i++){
                    Console.Write("Arr["+i+"]=");
                    Arr[i] = Convert.ToDouble(Console.ReadLine());
                }
                
                double min = Arr[0];
                for(int i = 0;i<size;i++){
                    if(Arr[i]<min){
                        min = Arr[i];
                    }
                }

                for(int i = 0;i<size;i++){
                    if(Arr[i] == min){
                        Console.Write(i+" ");
                    }
                }
            }
            void task3(){
                
                    Console.WriteLine("Enter Size(NxN)");
                    Console.Write("N:");
                    int N = Convert.ToInt32(Console.ReadLine());
                    int[,] Arr = new int[N,N];


                    for(int i = 0;i<N;i++){
                        for(int j = 0; j<N;j++){
                            Console.Write("Arr["+i+" "+j+"]=");
                            Arr[i,j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    int sum = 0 ;
                    int k = 0 ;
                    for(int i = 0;i<N;i++){
                        for(int j = 0; j<N;j++){
                            if(j>=i)continue;
                            if(Arr[i,j]%2 == 0){
                                sum += Arr[i,j];
                                k++;
                                }
                        }
                    }
                    if(k==0){
                        Console.WriteLine("There is no odd values!");
                    }
                    else{
                        Console.WriteLine("Average = "+ (sum/k) );
                        }
                
            }

            void task4(){            
                Console.WriteLine("Enter size(number of rows):");
                int rows = Convert.ToInt32(Console.ReadLine());
                int[][] Arr = new int[rows][];
                int maxRow = 0;

                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine("Enter size of " + (i + 1) + " row");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Arr[i] = new int[row];

                    for (int j = 0; j < row; j++)
                    {
                        Console.WriteLine("Arr[" + i + "][" + j + "]");
                        Arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    }

                    if (row > maxRow) maxRow = row;
                }

                int[] Result = new int[maxRow];

                for (int j = 0; j < maxRow; j++)
                {
                    int min = int.MaxValue;
                    for (int i = 0; i < rows; i++)
                    {
                        if (Arr[i].Length <= j) continue;
                        if (min > Arr[i][j]) min = Arr[i][j];
                    }
                    Result[j] = min;
                }

                for (int i = 0; i < maxRow; i++)
                {
                    Console.WriteLine("Result[" + i + "]=" + Result[i]);
                }


            }




            
            void choose_task(){
            Console.Write("1.Заміна значеннь менше Value\n2.Вивести \n3.Середне ариф. серед парних нижще головної діагоналі\n4.Мінімальне в стовпці\n");
            int answer = Convert.ToInt16(System.Console.ReadLine());

            switch (answer){
                case 1:{
                    task1();
                    Console.Write("\n\n\n");
                    choose_task();
                    break;
                }
                case 2:{
                    task2();
                    Console.Write("\n\n\n");
                    choose_task();
                    break;
                }
                case 3:{
                    task3();
                    Console.Write("\n\n\n");
                    choose_task();
                    break;
                    }
                case 4:{
                    task4();
                    Console.Write("\n\n\n");
                    choose_task();
                    break;
                    }
                default:{
                    choose_task();
                    break;
                }

            }
        }
            Console.WriteLine("Привіт!");
            choose_task();

        }
    }
}