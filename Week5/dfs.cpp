#include <iostream>
#include <vector>
#include <stack>
using namespace std;

void DFS(int start, vector<vector<int>> &adj, vector<bool> &visited) {
    stack<int> s;
    s.push(start);
    visited[start] = true;

    while (!s.empty()) {
        int node = s.top();
        s.pop();
        cout << node << " ";

        for (int neighbor : adj[node]) {
            if (!visited[neighbor]) {
                s.push(neighbor);
                visited[neighbor] = true;
            }
        }
    }
}

int main() {
    int n = 5;
    vector<vector<int>> adj(n);
    adj[0] = {1, 5}; adj[1] = {0, 3, 4};
    adj[2] = {0}; adj[3] = {1};
    adj[4] = {1};
    vector<bool> visited(n, false);
    cout << "Traversal: ";
    DFS(0, adj, visited);
    cout << endl;

    return 0;
}
