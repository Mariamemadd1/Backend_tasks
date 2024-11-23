#include <iostream>
using namespace std;
const int  mx=100;
class stack {
    int top;
    int st[mx];
public:
    stack() {
        top=-1;
    }
    bool is_empty() {
        return top<0;
    }
    bool is_full() {
        return top>mx;
    }
    void push(int item) {
        if(is_full()) {
            cout<<"can't add item , stack is full";
        }
        else {
            top++;
            st[top]=item;
        }
    }
    void pop () {
        if(is_empty()) {
            cout<<"no item to pop ,stack is empty";
        }
        else {
            top--;
        }
    }
    void display() {
        if(is_empty()) {
            cout<<"no item to display ,stack is empty";
        }
        else {
            for (int i=top;i>=top;i--) {
                cout<<'[';
                cout<< st[top]<<" ";
            }
            cout<<']';
        }
    }
};
int main() {
    stack s;
    while (true) {
        cout<<" 1 : Push item to stack"<<endl;
        cout<<" 2 : pop item from stack"<<endl;
        cout<<" 3 : Display items in stack"<<endl;
        cout<<"enter num of operation : "<<endl;
        int op_val,item;
        cin>>op_val;
        if(op_val==1) {
            cout<<"enter item to push : ";
            cin>>item;
            s.push(item);
        }
        else if(op_val==2) {
            s.pop();
        }
        else if(op_val==3) {
            s.display();
        }
        else {
            cout<<"enter a valid op";
        }
        cout<<"-----------------------------------------"<<endl;
    }


    return 0;
}
