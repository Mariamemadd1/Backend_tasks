#include <iostream>
#include <cassert>
using namespace std;
const int mx=100;
class Queue_with_array {
    int front;
    int rear;
    int length;
    int arr[mx];
public:
    Queue_with_array() {
        front=-1;
        rear=-1;
        length=0;
        arr[mx]={0};
    }
    bool isempty() {
        return length==0;
    }
    bool isfull() {
        return length==mx;
    }
    void add(int item) {
        if(isfull()) {
            cout<<"Queue is full,can't add "<<endl;
        }
        else{

                rear = (rear + 1) % mx;
                arr[rear] = item;
                length++;

        }
    }
    void remove() {
        if (isempty()) {
            cout<<"queue is empty , can't remove"<<endl;

        }
        else {
            front = (front + 1) % mx;
            --length;
        }
    }
    int getfront() {
        assert(!isempty());
        return arr[front];
    }
    int getrear() {
        assert(!isempty());
        return arr[rear];
    }
    void printQ() {
        if(!isempty()){
            for (int i=front;i!=rear;i=(i+1)%mx) {
                 cout<<arr[i]<<" ";
            }
            cout<<arr[rear];
        }
        else {
            cout<<"queue is empty"<<endl;
        }
    }
    void search(int item) {
        int pos =-1;

        if(!isempty()) {
            for (int i=front;i!=rear;i=(i+1)%mx) {
                if (arr[i]==item) {
                    pos=item;
                    break;
                }
            }
        }
        if (pos == -1)
        {
            if (arr[rear] == item)
                pos = rear;
        }
        if (pos!=-1) {
            cout<<"item in queue"<<endl;
        }
        else {
            cout<<"item not in queue"<<endl;
        }
    }

};
int main() {
Queue_with_array Q;
    Q.add(10);
    Q.add(20);
    Q.add(30);
    Q.add(40);
    Q.add(50);
    Q.remove();
    Q.printQ();
    Q.search(10);
    return 0;
}
