the user will indicate if the want to order bread or pastries

function will take in quantity



    public int NumOfLoaves { get; set; }
    public int 

    public static int BreadTotal(int inputtedBreadOrder) //method
    {
      NumOfLoaves = inputtedBreadOrder;
      int breadOrderCost = 0; //starting value is 0- will add to this to get bread total cost
      int singleLoafCost = 5;
    }
    public int CalculateBreadTotalCost()
    {
      BreadTotal.breadOrderCost = BreadTotal.singleLoafCost * BreadTotal.NumOfLoaves;
      return BreadTotal.breadOrderCost;
    }