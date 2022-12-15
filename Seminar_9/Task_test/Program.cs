// See https://aka.ms/new-console-template for more information
void a(int b){
    if(b>=1){
        a(b-1);
        Console.Write($"{b} ");
        a(b-1);
    }
}
a(7);