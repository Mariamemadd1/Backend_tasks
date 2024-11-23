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
    bool bar_checker(string s) {
        stack str;
        bool balanced=true;
       int index=0;
        while(index <s.length()&balanced){
            if (s[index]=='(') {
                str.push('(');
            }
            else {
                if(str.IsEmpty()) {
                    balanced=false;
                }
                else {
                    str.pop();
                }
            }
            index++;
        }
        if (balanced&str.IsEmpty()) {
            return true;
        }
        else {
            return false;
        }
    }

};
int main() {
   stack bar;
    string s;
    cin>>s;
    if(bar.bar_checker(s)) {
        cout<<"Balanced";
    }
    else {
        cout<<"Not balanced";
    }

    return 0;
}
