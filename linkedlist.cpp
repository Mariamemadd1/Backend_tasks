#include <iostream>
#include <cassert>
using namespace std;
class Node {
public:
    int data;
    Node*next;
};
class lst {
    Node*Head;
    Node *last;

    int length;
public:
    lst(){
        length=0;
        Head=NULL;
        last=NULL;

    }
    bool isempty() {
        return Head==NULL;
    }
    void insertfirst(int item) {
        Node *newnode= new Node();
            newnode->data=item;
        if (isempty()) {
            Head=last=newnode;
            newnode->next=NULL;

        }
        else {

            newnode->next=Head;
            Head=newnode;
        }
        length++;
    }
    void insertlast(int item) {
        Node *newnode= new Node();
        newnode->data=item;
        if (isempty()) {
            Head=last=newnode;
            newnode->next=NULL;

        }
        else {

            last->next=newnode;
            last=newnode;
            newnode->next=NULL;
        }
        length++;
    }
    void insertat(int pos ,int item) {
        Node *newnode= new Node();
        newnode->data=item;
        if(pos==0) {
            insertfirst(item);
        }
        else if(pos==length) {
            insertlast(item);
        }
        else if(pos<0) {
            cout<<"invalid position";
        }
        else {
            Node *tmp=Head;
            for (int i=1;i<pos;i++) {
                tmp=tmp->next;
            }
            newnode->next=tmp->next;
            tmp->next=newnode;
        }
        length++;
    }
    void removefirst() {
        if (length==0) {
            cout<<"can't delete items";
        }
        else if (length==1) {
            delete Head;
        }
        else {
            Node *ptr=Head;
            Head=Head->next;
            delete ptr;
        }
    }
    void removelast() {
        if (length==0) {
            cout<<"can't delete items";
        }
        else if (length==1) {
            delete Head;
        }
        else {
            Node *ptr=Head->next;
            Node *prev=Head;
            while(ptr!=last) {
                prev=ptr;
                ptr=ptr->next;
            }
            delete ptr;
            prev->next=NULL;
            last=prev;
            length--;
        }
    }
    void print() {
        Node *temp=Head;
        while (temp!=NULL) {
            cout<<temp->data<<" ";
            temp=temp->next;
        }
        cout<<endl;
    }
    bool search(int item) {
        Node *ptr=Head;
        while (ptr!=NULL) {
            if(ptr->data==item) {
                return true;
            }
            ptr=ptr->next;
        }
        return false;
    }
};
int main() {
lst l;
    l.insertfirst(10);
    l.insertfirst(20);
    l.insertlast(30);
    l.insertlast(40);
    l.print();
    l.insertat(2,100);
    l.removefirst();
    l.print();
    l.removelast();
    l.print();
    if (l.search(100)) {
        cout<<"item founded";
    }
    else {
        cout<<"item not found";
    }
}
