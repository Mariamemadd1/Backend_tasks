#include <iostream>
#include <cassert>
using namespace std;
class DoubleLinkedList {
    struct Node {
        int data;
        Node*next;
        Node*prev;
    };
    Node*Head;
    Node*Last;
    int count;

public:
    DoubleLinkedList(){
        Head=Last=NULL;
        count=0;
        }
    void insertFirst(int item){
        Node*newnode=new Node();
        newnode->data=item;
        if (count==0) {
            Head=Last=newnode;
            newnode->prev=newnode->next=NULL;
            count++;
        }
        else {
            newnode->next=Head;
            newnode->prev=NULL;
            Head=newnode;
            count++;
        }
    }
    void insertLast(int item) {
        Node*newnode=new Node();
        newnode->data=item;
        if (count==0) {
                insertFirst(item);
        }
        else {
            newnode->next=NULL;
            newnode->prev=Last;
            Last->next=newnode;
            Last=newnode;
            count++;
        }
    }
    void insertAt(int pos,int item) {
        if (pos<0||pos>count) {
            cout<<"invalid index"<<endl;
        }
        else if(pos==0){
            insertFirst(item);
        }
        else if(pos==count) {
            insertLast(item);
        }
        else {
            Node*newnode=new Node();
            newnode->data=item;
            Node * curr=Head->next;
            for (int i = 1; i < pos; i++) {
               curr=curr->next;
            }
            newnode->prev=curr;
            newnode->next=curr->next;
            curr->next->prev = newnode;
            curr->next=newnode;
            count++;
        }
    }
    void removeFirst() {
        if(count==0) {
            cout<<"can't delete items"<<endl;
        }
        else if(count==1) {
            delete Head;
            Head=Last=NULL;
            count--;
        }
        else {
            Node *curr=Head;
            Head=Head->next;
            Head->prev=NULL;
            delete curr;
            count--;
        }
    }
    void removeLast() {
        if(count==0) {
            cout<<"can't delete items"<<endl;
        }
        else if(count==1) {
            removeFirst();
        }
        else {
            Node*curr=Last;
            Last=Last->prev;
            Last->next=NULL;
            delete curr;
            count--;
        }
    }
    void removeAt(int pos) {
        if (pos<0||pos>count) {
            cout<<"can't remove items"<<endl;
        }
        else if (pos==0) {
            removeFirst();
        }
        else if(pos==count) {
            removeLast();
        }
        else {
            Node*curr=Head->next;
            for (int i = 1; i < pos; i++) {
                curr=curr->next;
            }
            curr->prev->next = curr->next;
            curr->next->prev = curr->prev;
            delete curr;
            count--;
        }
    }
    void print() {
        Node*ptr=Head;
        while (ptr!=NULL) {
            cout<<ptr->data<<" ";
            ptr=ptr->next;
        }
        cout<<endl;
    }
    void reverse() {
        Node*n=Last;
        while (n!=NULL) {
            cout<<n->data<<" ";
            n=n->prev;
        }
        cout<<endl;
    }
};


int main() {
DoubleLinkedList DLL;
    DLL.insertAt(0,40);
    DLL.insertFirst(10);
    DLL.insertFirst(20);
    DLL.insertLast(30);
    DLL.print();
    DLL.removeLast();
    DLL.print();
    DLL.removeFirst();
    DLL.print();
    DLL.removeAt(2);
    DLL.print();
    DLL.insertFirst(100);
    DLL.reverse();

}
