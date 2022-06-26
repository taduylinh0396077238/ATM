class ATM
{
    static void Main(string[] args )
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int count = 0;
        int ch=1;
        string cardID;
        string password;
        long ballance = 500000; //số dư

        int request;
       


        do
        {
            Console.WriteLine("Moi ban nhap tk");
            cardID = Console.ReadLine();
            Console.WriteLine("Moi ban nhap mk");
            password = Console.ReadLine();

            if(cardID=="123" && password == "456")
            {
                do
                {
                    Console.WriteLine("Mời bạn chọn yêu cầu");
                    request = Convert.ToInt32(Console.ReadLine());
                    switch (request)
                    {
                        case 1:
                            int amount = default; // số tiền rút
                            int isWithdrawable = default; // có thể rút 
                            
                            Console.WriteLine("1. Rút Tiền");
                            amount = Convert.ToInt32(Console.ReadLine());
                            if (amount > ballance )
                            {
                                Console.WriteLine("Số tiền vượt quá số tiền rút");
                            }else if(amount < 30000 && amount % 50 ==0 )
                            {
                                Console.WriteLine("Rút tiền thành công");
                                ballance -= isWithdrawable;
                                ballance -= amount;
                                Console.WriteLine($"Số tiền đã  rút : {amount} ");
                                Console.WriteLine($"Kiểm tra số dư : {ballance} " );

                            }else
                            {
                                Console.WriteLine("Số tiền phải nỏ hơn 300 và là bội của 50");
                            }


                            break;

                            case 2:
                            Console.WriteLine("2. Chuyển tiền");
                            int stk = default;
                            Console.WriteLine("Moi ban nhap tk dich");
                            stk = Convert.ToInt32(Console.ReadLine());
                            int transfer = 0;
                            Console.WriteLine("Nhap so tien muon chuyen");
                            transfer = Convert.ToInt32(Console.ReadLine());
                            if (transfer > ballance)
                            {
                                Console.WriteLine("Chuyển tiền không thành công");
                            } else if (transfer > 10000) {
                                Console.WriteLine("Chuyển tiền thành  công");
                                ballance -= transfer;
                                Console.WriteLine($"Số tiền đã chuyển là : {transfer}");
                                Console.WriteLine($"Kiểm tra số dư : {ballance}");
                            } else {
                                Console.WriteLine("Số tiền chuyển phải lớn hơn 10000");
                                    }


                            break ;
                            case 3:
                            Console.WriteLine("3.Hiển thị số dư  ");
                            Console.WriteLine($"Số dư hiện tại là: {ballance}");
                            break;
                        default:
                            break;
                    }


                    Console.WriteLine("Ban co muon tiep tuc khong?[0/1]");
                    ch = Convert.ToInt32(Console.ReadLine());
                }while(ch==1);
            }
            else
            {
                Console.WriteLine("Sai tai khoan hoac mk");
                count++;
            }

        }while(count<=3 && ch!=0);








        
    }
}