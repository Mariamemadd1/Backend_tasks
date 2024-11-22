#include <iostream>
using namespace std;
class Node {
public:
    int data ;
    Node *next;
};
class stack {
    Node*Top;
public:
    stack() {
        Top=NULL;
    }
    bool IsEmpty() {
        return (Top==NULL);
    }
    int cnt=0;
    void push(int item) {
        Node *new_node=new Node();
        new_node->data=item;
        cnt++;
        if (IsEmpty()) {
            new_node->next=NULL;
            Top=new_node;
        }
        else {
            new_node->next=Top;
            Top=new_node;
        }
    }
    void display() {
        Node *ptr=Top;
        cout<<"items in stack : ";
        while (ptr!=NULL) {
            cout<<ptr->data<<" ";
            ptr=ptr->next;
        }
        cout <<endl;
        cout<<"num of items : "<<cnt<<endl;
    }
    void pop () {
        if(IsEmpty()) {
            cout<<" No items to delete"<<endl;
        }
        else {
            Node *delptr=Top;
            Top=Top->next;
            cout <<"you delete item : "<<delptr->data<<endl;
            delete delptr;
            cnt--;
        }
    }
   string Search(int item ) {
        Node*ptr=Top;
        while(ptr!=NULL) {
            if (ptr->data==item) {
                return "item founded !\n";
            }
            ptr=ptr->next;
        }
        return "item not founded\n ";
    }
    void peek() {
        cout<<"top item is : "<<Top->data<<endl;
    }
};
int main() {
    stack s;
    while (true) {
        cout<<" 1 : Push item to stack"<<endl;
        cout<<" 2 : pop item from stack"<<endl;
        cout<<" 3 : Display items in stack"<<endl;
        cout<<" 4 : Top item in stack"<<endl;
        cout<<" 5 : search item in stack"<<endl;
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
        else if(op_val==4) {
            s.peek();
        }
        else if(op_val==5) {
            cout<<"enter item to search : ";
            cin>>item;
            cout<< s.Search(item);
        }
        else {
            cout<<"enter a valid op";
        }
        cout<<"-----------------------------------------";
    }
    return 0;
}
