int [] array = {10, 29,83,44,90,64,7,90,};

int n = array.Length;
int find = 90;
int index =0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
