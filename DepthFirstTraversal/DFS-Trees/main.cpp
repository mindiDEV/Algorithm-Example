#include <iostream>
#include <list>
using namespace std;

#define NUM_V 4

//graph : biểu đồ
bool helper(list<int> *graph, int u, bool *visited, bool *recStack)
{
	visited[u] = true;
	recStack[u] = true;
	list<int>::iterator i;
	for (i = graph[u].begin(); i != graph[u].end(); ++i)
	{
		if (recStack[*i])
		{
			return true;
		}
		else if (*i == u)
		{
			return true;
		}
		else if(!visited[*i])
		{
			if (helper(graph, *i, visited, recStack))
			{
				return true;
			}
		}
		
	}
	recStack[u] = false;
	return false;
}



int main()
{
	cout << "Hello world\n";
	system("pause");
	return 0;
}