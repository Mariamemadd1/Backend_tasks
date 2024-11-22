class Node {
public:
    int data;
    Node*next;
    Node(){
        data=NULL;
        next=NULL;
    }
};
int cnt=0;
class Queue {
    Node*front;
    Node*back;
public:
    Queue(){
        front=back=NULL;
    }
    bool Is_empty() {
        return (front==NULL&&back==NULL);
    }
    void enqueue(int item ) {
        Node*new_node=new Node();
        new_node->data=item;
        if (Is_empty()) {
           front=back=new_node;
        }
        else {
             back->next=new_node;
            back=new_node;
        }
        cnt++;
    }
    void display() {
        if(Is_empty()) {
            cout<<"no items to display";
        }
        else {
            Node*temp=front;
            while(temp!=NULL) {
                cout<<temp->data<<" ";
                temp=temp->next;
            }
            cout<<endl;
        }
    }
    void Dequeue() {
        if(Is_empty()) {
            cout<<"no item to remove";
        }
        else {
            Node*delptr=front;
            front=front->next;
            delete delptr;
            cnt--;
        }

    }
    void peek() {
        cout<<" front is : " <<front->data<<endl;
    }
    void search(int item ) {
        Node*search_ptr=front;
        bool isfound=false;
        while(search_ptr!=NULL) {
            if(item==search_ptr->data) {
                isfound=1;
            }
            search_ptr=search_ptr->next;
        }
        if (isfound==1) {
            cout<<"item founded!";
        }
        else {
            cout<<"item not founded ..";
        }

    }
    void counter() {
        cout<<" items in queue : "<<cnt<<endl;
    }
    void clear() {
        Node*ptr=front;
        while(ptr!=NULL) {
            Dequeue();
        }
    }
};

int main() {
  
}
