public class ListasEnlazadas {
    private node head;
    private node tail;
    private string name;

    public createlist (string listName){
        name=listName;
        head=tail=null;
    }

    public bool isListEmpty (){
        if(head==null){
            return true
        }
        return false;
    }

    public void insertHeadNode(int data){
        if(isListEmpty){
            head= tail= new node (data);
        }
        else{
            node n = new node ();
            n.setData(data);
            n.setNext(head);
            head = n;
        }
        
    }

    public void insertTailNode(int data){
        if(isListEmpty){
            head= tail= new node (data); 
        }
        else{
            node n = new node (data);
            tail.next = n;
            tail = n;
        }
    }
    public int deleteHead(){
        if(isListEmpty){
            throw nex emptyListException (name);
        }
        int deleteNode = head.getData;
        if(head == tail){
            head = tail = null;
        }
        else {
            head = head.getNetx;
        }
        return deleteNode;
    }
}