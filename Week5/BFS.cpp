#include <iostream>
#include <vector>
#include <queue>

using namespace std;

void BFS(vector<vector<int>> &graph, int start) {
    int z = graph.size();
    vector<bool> visited(z, false);
    queue<int> q;

    visited[start] = true;
    q.push(start);

    while (!q.empty()) {
        int node = q.front();
        q.pop();
        cout << node << " ";

        for (int adj : graph[node]) {
            if (!visited[adj]) {
                visited[adj] = true;
                q.push(adj);
            }
        }
    }
}

int main() {
    vector<vector<int>> graph = {
        {1, 2},
        {0, 5, 4},
        {0, 4, 6},
        {1},
        {1},
        {2},
        {2}
    };

    cout << "Traversal: ";
    BFS(graph, 0);
    return 0;
}
