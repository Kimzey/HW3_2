class Program
{
    static void HW_2(){
                Queue<char> Input = new Queue<char>();
        CircularLinkedList<int> Output = new CircularLinkedList<int>();

        while(true){
            Console.Write("Input Size {L,M,S}: ");
            char size_input = char.Parse(Console.ReadLine());
            if(size_input != 'L' && size_input != 'M' && size_input != 'S'){
                break;
            }
            else{
                Input.Push(size_input);
            }}
        while(true){
            char getpop = Input.Pop() ;

                if(getpop == 'L'){
                    //Console.WriteLine("if L");
                    Input.Push('M');
                    Input.Push('M');
                    Output.Add(1);
                }
                else if (getpop == 'M'){
                    //Console.WriteLine("if M");
                    Input.Push('S');
                    Input.Push('S');
                    Input.Push('S');
                    Output.Add(2);
                }
                else if (getpop == 'S'){
                    //Console.WriteLine("if S");
                    Output.Add(3);
                }

                if(Input.GetLength() == 0){
                    break;
                }
                //Console.WriteLine("Length = {0}",Input.GetLength());
        }
        Console.WriteLine("_____________________________________________________________________________");
        for (int i = 0 ; i < Output.GetLength() ; i++){
                Console.Write(Output.Get(i));
            }   
            Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        HW_2();
    }
}