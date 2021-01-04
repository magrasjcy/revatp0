using System;

namespace com.pizzaworld.Orders
{
   class Order {
//	   public static JsonValue Parse(string jsonString)
	//public  interface InputFacetI {
	//   public string  getInput();
	//}
	//public static class CLI implements Order.InputFacetI {
       public void getInput() {    
	    int index,sizeNo,countNo;
	    string storeInput=Console.ReadLine();
	    string input,finInput=" ";
	    string sizeInput,countInput,pizzaInput;
	    do {
	        Console.WriteLine("Is this location near you?");
	        storeInput=Console.ReadLine();
	    } while (storeInput[0]!='Y') ;
		    
            do {
		if (finInput[0]=='D') {
		    int delIndx=1;
		    for (uint udelIndx=1;udelIndx<this.arrayIdx;udelIndx++)  {
			    Console.WriteLine(udelIndx+" "+this.items[udelIndx-1]);
		    }
	            Console.WriteLine("which index pizza would you remove?");
                    input=Console.ReadLine();
                    Int32.TryParse(input,out delIndx);
		    for (int udelIndx=delIndx;udelIndx<this.arrayIdx;udelIndx++)
			    this.items[udelIndx+1]=this.items[udelIndx];
		}
	        Console.WriteLine("what pizza would you like?");
                input=Console.ReadLine();
                Int32.TryParse(input,out index);
                Console.WriteLine("what size pizza would you like?");
                sizeInput=Console.ReadLine();
                Int32.TryParse(sizeInput,out sizeNo);

                Console.WriteLine("How many pizzas of this type & size would you like?");
                countInput=Console.ReadLine();
                Int32.TryParse(countInput,out countNo);
	//}
                do {
		      	Console.WriteLine("Is this pizza acceptable?(y/n)");
                     pizzaInput=Console.ReadLine();
		     
		}while (pizzaInput[0]!='Y'&&pizzaInput[0]!='N');
		if (pizzaInput[0]=='Y') {
                    Pizza pizza=new Pizza((uint)index,(uint)sizeNo,(uint)countNo);//pizza type size count	
		    this.items[arrayIdx++]=pizza;
		}
                do {	
                   Console.WriteLine("Is this order accurate and complete?(C:omplete,M:ore,D:el");
                   finInput=Console.ReadLine();
	        } while(finInput[0]!='C'&& finInput[0]!='M'&&finInput[0]!='D');
	}   while ( finInput[0]!='C' && this.arrayIdx<12);
	}
        private uint arrayIdx {get;set;}   
        private ulong sequence
       	{ get;set;}
	private string address {get; set;} 
	private string name  {get; set;}
	private string payment {get;set;}
        private float amount {get;set;}
	private Pizza[]  items; 
	
	public static Order build(uint unitno) { 
	    
            Order order=new Order();
	    order.items=new Pizza[12];
	    order.getInput();
	    // order.items=sizeInput;
	    // order.items=input;
	    return order;
	}
    }

}

