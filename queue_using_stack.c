#include<stdio.h>
#define inf -10000
int stack[2][100], top[2] = {0,0};

void push(int stack_in, int value){

    stack[stack_in][top[stack_in]] = value; 
    top[stack_in] ++;
}

int pop(int stack_in){
    if(top[stack_in] == 0){
        printf("UnderFlow!!..\n");
        return inf;
    }

    return stack[stack_in][--top[stack_in]];
}

int main() {
    int command, value,x,y;
    while(1) {
        printf("\n[1] Insert into QUEUE\n[2] Delete from QUEUE\n\nEnter your command: ");
        scanf(" %d",&command);
        printf("\n");
        switch(command){
            case 1: //ENQUEUE
                printf("\nEnter value to Enqueue: ");
                scanf("%d",&value);
                push(1,value);
                printf("Insertion sucessfull.\n\n");
                break;
            
            case 2: //DEQUEUE
                while(top[1] > 1){
                    x = pop(1);
                    push(2,x);
                }
                y = pop(1);
                while(top[2] > 0){
                    x = pop(2);
                    push(1,x);
                }
                if(y != inf) printf("Deleted successfull. Deleted Element is %d\n\n",y);
                break;
            
            default: // print all elements.
                printf("Elements of the queue are...\n");
                for(int i=0;i<top[1];i++){

                    printf("%d\t",stack[1][i]);
                }
                printf("\n");

        }

    }
    return 0;
}