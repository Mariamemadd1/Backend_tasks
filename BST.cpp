#include <iostream>
#include <algorithm>
using namespace std;
class node{
public:
    int info;
    node* leftchild , *rightchild;
    node(int value) {
        info=value;
        leftchild=rightchild=NULL;
    }
};
class binarytree {
public:
    node*root;
    binarytree() {
        root=NULL;
    }
    node* insert(node *r, int item) {
        if(r==NULL) {
            node *newnode=new node(item);
            r=newnode;
        }
        else if(item< r->info) {
            r->leftchild=insert(r->leftchild,item);
        }
        else {
            r->rightchild=insert(r->rightchild,item);
        }
        return r;
    }
    void insert(int item) { //overriding
        root=insert(root,item);
    }
    //traversal
    void preorder(node *p)   { //root left right
        if (p==NULL) {
            return;
        }
        cout<<p->info<<" ";
        preorder(p->leftchild);
        preorder(p->rightchild);

    }
    void postorder(node *p) { //left right root
        if (p==NULL) {
            return;
        }
        postorder(p->leftchild);
        postorder(p->rightchild);
        cout<<p->info<<" ";

    }
    void inorder(node *p ) { //left root right
        if (p==NULL) {
            return;
        }
        inorder(p->leftchild);
        cout<<p->info<< " ";
        inorder(p->rightchild);
    }
    node* minvalue(node *r) {
        if (r==NULL) {
            return NULL;
        }
        else if (r->leftchild==NULL) {
            return r;
        }
        else {
            return minvalue(r->leftchild);
        }
    }
    node *maxvalue(node *r) {
        if (r==NULL) {
            return NULL;
        }
        else if (r->rightchild==NULL) {
            return r;
        }
        else {
            return maxvalue(r->rightchild);
        }
    }
    node* search(node *p , int key) {
        if (p==NULL) {
            return NULL;
        }
        else if(key==p->info) {
            return p;
        }
        else if(key<p->info) {
            return search(p->leftchild,key);
        }
        else if(key>p->info) {
            return search(p->rightchild,key);
        }
    }
    bool search(int key) {
        node* result=search(root,key);
        if(result==NULL) {
            cout<<"item not found"<<endl;
        }

        else{
            cout<<"item founded !"<<endl;
        }
    }
    node*  Delete(node* r, int key)
    {
        if (r == NULL) // Empty Tree
            return NULL;
        if (key < r->info) // Item exists in left sub tree
            r->leftchild = Delete(r->leftchild, key);
        else if (key > r->info) // item exists in right sub tree
            r->rightchild =Delete(r->rightchild, key);
        else
        {
            if (r->leftchild == NULL && r->rightchild == NULL) // leaf node
                r = NULL;
            else if (r->leftchild != NULL && r->rightchild == NULL) // one child on the left
            {
                r->info = r->leftchild->info;
                delete r->leftchild;
                r->leftchild = NULL;
            }
            else if (r->leftchild == NULL && r->rightchild != NULL) // one child on the right
            {
                r->info = r->rightchild->info;
                delete r->rightchild;
                r->rightchild = NULL;
            }
            else
            {
                node* max = maxvalue(r->leftchild);
                r->info = max->info;
                r->leftchild=	Delete(r->leftchild, max->info);

            }

        }
        return r;
    }
    };
    int main() {
        //45, 15, 79, 90, 10, 55, 12, 20, 50
        binarytree btree;
        btree.insert(45);
        btree.insert(15);
        btree.insert(79);
        btree.insert(90);
        btree.insert(10);
        btree.insert(55);
        btree.insert(12);
        btree.insert(20);
        btree.insert(50);

        cout<< " in order traverse "<<endl;
        btree.inorder(btree.root);
        cout<<endl<<"------------------"<<endl;
        cout<< " pre order traverse "<<endl;
        btree.preorder(btree.root);
        cout<<endl<<"------------------"<<endl;
        cout<< " post order traverse "<<endl;
        btree.postorder(btree.root);
        cout<<endl<<"------------------"<<endl;
        cout << " find minimum "<< " ";
        node *mini=btree.minvalue(btree.root);
        if(mini!=NULL) {
            cout<<" mini is : "<< mini->info << endl;
        }
        else {
            cout<<"no items in tree"<<endl;
        }

        cout << " find maximum "<< " ";
        node *mx=btree.maxvalue(btree.root);
        if(mx!=NULL) {
            cout<<" max is : "<< mx->info << endl;
        }
        else {
            cout<<"no items in tree"<<endl;
        }
        return 0;
    }


