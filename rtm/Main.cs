using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rtm
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

                                                                                                                                          
                                                                                                                                  
           //                 BBBBBBBBBBBBBBBBB                                          kkkkkkkk                                                    
           //                 B::::::::::::::::B                                         k::::::k                                                    
           //                 B::::::BBBBBB:::::B                                        k::::::k                                                    
           //                 BB:::::B     B:::::B                                       k::::::k                                                    
           //                   B::::B     B:::::B    eeeeeeeeeeee    rrrrr   rrrrrrrrr   k:::::k    kkkkkkk eeeeeeeeeeee       mmmmmmm    mmmmmmm   
           //                   B::::B     B:::::B  ee::::::::::::ee  r::::rrr:::::::::r  k:::::k   k:::::kee::::::::::::ee   mm:::::::m  m:::::::mm 
           //                   B::::BBBBBB:::::B  e::::::eeeee:::::eer:::::::::::::::::r k:::::k  k:::::ke::::::eeeee:::::eem::::::::::mm::::::::::m
           //                   B:::::::::::::BB  e::::::e     e:::::err::::::rrrrr::::::rk:::::k k:::::ke::::::e     e:::::em::::::::::::::::::::::m
           //                   B::::BBBBBB:::::B e:::::::eeeee::::::e r:::::r     r:::::rk::::::k:::::k e:::::::eeeee::::::em:::::mmm::::::mmm:::::m
           //                   B::::B     B:::::Be:::::::::::::::::e  r:::::r     rrrrrrrk:::::::::::k  e:::::::::::::::::e m::::m   m::::m   m::::m
           //                   B::::B     B:::::Be::::::eeeeeeeeeee   r:::::r            k:::::::::::k  e::::::eeeeeeeeeee  m::::m   m::::m   m::::m
           //                   B::::B     B:::::Be:::::::e            r:::::r            k::::::k:::::k e:::::::e           m::::m   m::::m   m::::m
           //                 BB:::::BBBBBB::::::Be::::::::e           r:::::r           k::::::k k:::::ke::::::::e          m::::m   m::::m   m::::m
           //                 B:::::::::::::::::B  e::::::::eeeeeeee   r:::::r           k::::::k  k:::::ke::::::::eeeeeeee  m::::m   m::::m   m::::m
           //                 B::::::::::::::::B    ee:::::::::::::e   r:::::r           k::::::k   k:::::kee:::::::::::::e  m::::m   m::::m   m::::m
           //                 BBBBBBBBBBBBBBBBB       eeeeeeeeeeeeee   rrrrrrr           kkkkkkkk    kkkkkkk eeeeeeeeeeeeee  mmmmmm   mmmmmm   mmmmmm
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
                                                                                                                                                   
           //                 MMMMMMMM               MMMMMMMMEEEEEEEEEEEEEEEEEEEEEETTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEE                         
           //                 M:::::::M             M:::::::ME::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E                     
           //                 M::::::::M           M::::::::ME::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E                     
           //                 M:::::::::M         M:::::::::MEE::::::EEEEEEEEE::::ET:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::E                     
           //                 M::::::::::M       M::::::::::M  E:::::E       EEEEEETTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE                     
           //                 M:::::::::::M     M:::::::::::M  E:::::E                     T:::::T          E:::::E                                  
           //                 M:::::::M::::M   M::::M:::::::M  E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE                        
           //                 M::::::M M::::M M::::M M::::::M  E:::::::::::::::E           T:::::T          E:::::::::::::::E                        
           //                 M::::::M  M::::M::::M  M::::::M  E:::::::::::::::E           T:::::T          E:::::::::::::::E                        
           //                 M::::::M   M:::::::M   M::::::M  E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE                        
           //                 M::::::M    M:::::M    M::::::M  E:::::E                     T:::::T          E:::::E                                  
           //                 M::::::M     MMMMM     M::::::M  E:::::E       EEEEEE        T:::::T          E:::::E       EEEEEE                     
           //                 M::::::M               M::::::MEE::::::EEEEEEEE:::::E      TT:::::::TT      EE::::::EEEEEEEE:::::E                     
           //                 M::::::M               M::::::ME::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E                     
           //                 M::::::M               M::::::ME::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E                     
           //                 MMMMMMMM               MMMMMMMMEEEEEEEEEEEEEEEEEEEEEE      TTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEE                     
                                                                                                                                  
                                                                                                                                  
                                                               



        private void button1_Click(object sender, EventArgs e)
        {
            rtm rtm = new rtm();
            rtm.Show();
            this.Hide();
        }
    }
}
