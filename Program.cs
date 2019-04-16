using System;

namespace ConsoleAppDemo
{
    class Program:AbstractUser
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! Apa kabar semua ");
            //String str = "ABCD"; 
            //int n = str.Length; 
            //permute(str, 0, n - 1); 
            
            short[] tmp1 = {1,0,0,0,0,1,0,0};
            CellCompute2(tmp1, 1);

            Console.WriteLine(" ");

            short[] tmp = {1,1,1,0,1,1,1,1};
            CellComputeHendra(tmp, 2);
            
            //int[] tmp = {21,36, 42};
            //FindGCD(tmp, 2);
            //

        }

        public static short[] CellCompute(short[] states, short days){
            short[] result = new short[8];
            for (short n = 1; n <= days; n++){
                //if (n == 1){
                    for (short i = 0; i < states.Length - 1; i++){
                        if (i == states.GetLowerBound(0) || i == states.GetUpperBound(0)) {
                            if (states[i + 1] == 0)
                                result[i] = 1;                            
                            else 
                                result[i] = 0;

                              
                        }
                       
                        Console.Write(result[i]);  
                        Console.Write(" ");  
                    }
                //}
                //else if (n == 2) {
                    //result[]
                //}
            }
            
            
            

            return result;
        }

        public static short[] CellCompute2(short[] states, short days){
            for(short i=0;i<days;i++)
            {
                short[] temp= new short[states.Length];
                for(int j = 0;j<states.Length;j++){
                    int before=0;
                    int after=0;
                    if(j==0) {
                        before = 0;
                        after = states[j+1];
                    }
                    else if(j == states.Length-1) { 
                        before = states[j-1];
                        after = 0; 
                    }
                    else {
                        before = states[j-1];
                        after = states[j+1];
                    }
                    
                    if(before == after){
                        temp[j] = 0;
                    }else{
                        temp[j] = 1;
                    }

                    

                }
                states=temp;

                
        
               
            }

            
            foreach (var c in states){
                    Console.Write(c);  
                Console.Write(" ");  
            }
                
            return states;
        }

        public static int[] CellComputeHendra(short[] states, short days){
            int[] result = new int[states.Length];
            for (int z = 0; z < days; z++){
                for (int a = 0; a < states.Length; a++){
                    result[a] = a == 0 ? (states[a + 1] | 0) : a == states.Length - 1 ? (states[a-1]|0) : (states[a - 1]|states[a + 1]);
                }
            }

            foreach (var c in result){
                    Console.Write(c);  
                Console.Write(" ");  
            }

            return result;
        }

        public static int FindGCD(int[] z, int n){
            int gcd = z[0];
            for (int i = 1; i < n; i++){
                gcd = GetGCD(z[i], gcd);
            }

            

            Console.WriteLine(gcd);
            return gcd;
        }
        public static int GetGCD(int x, int y)
        {
            if (y == 0)
                return x;

            return GetGCD(y, x % y);    
        }

        private static void permute(string str, int b, int c)
        {
            if (b == c) 
                Console.WriteLine(str); 
            else { 
                for (int i = b; i <= c; i++) { 
                    str = swap(str, b, i); 
                    permute(str, b + 1, c); 
                    str = swap(str, b, i); 
                } 
            }
        }

        public static String swap(String a, int i, int j) 
        { 
            char temp; 
            char[] charArray = a.ToCharArray(); 
            temp = charArray[i]; 
            charArray[i] = charArray[j]; 
            charArray[j] = temp; 
            string s = new string(charArray); 
            return s; 
        }

        public override void GetName()
        {
            throw new NotImplementedException();
        }

        public override string GetAddress(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
