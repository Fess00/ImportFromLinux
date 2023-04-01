
Random rand = new Random();

int[] b = new int[9];

int head = 0;
int tail = b.Length - 1;

for (int i = 0; i < 9; i++)
{
	b[i] = rand.Next(0, 2);
	Console.Write(b[i] + " ");
}

while(head < tail)
{
	if (b[head] == 0 && b[tail] == 1) {
		int swap = b[head];
		b[head] = b[tail];
		b[tail] = swap; 
	}
	else if (b[head] == 0) {
		tail--;
	}
	else if (b[tail] == 1) {
		head++;
	}
	else {
		head++;
		tail--;
	}
}
Console.WriteLine();
for (int i = 0; i < 9; i++)
{
	Console.Write(b[i] + " ");
}