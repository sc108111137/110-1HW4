using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW4{
    public partial class WebForm1 : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){

        int = 4;
        int i_input = i_X;
        if (i_X < 9){
            i_X = 8;
            }

        
        int i_X = 9;
            int[] ia_Arr = new int[(i_X + 1)];
            mt_Ini(ref ia_Arr);
            mt_Pri(ref ia_Arr);
            mt_Recur(ref ia_Arr, i_X);
            Response.Write(ia_Arr[i_input]);
            

        public int mt_Ini(ref int[] ia_Arr) {
            for (int i_ct=0 Ict< i_Arr.Length i_ct++){
            ia_Arr[i_ct] = 0
                    }
        }

            ia_Arr[1] = 2;
            ia_Arr[2] = 5;
            ia_Arr[3] = 9;
            ia_Arr[4] = 10;
            ia_Arr[5] = 15;
            ia_Arr[6] = 16;
            ia_Arr[7] = 19;
            ia_Arr[8] = 26;
            
        public int mt_Pri(ref int[] ia_Arr){
            for (int i_ct = 0 Ict < i_Arr.Length i_ct++){
                Response.Write(ia_Arr[i_ct]);
                Respinse.Write("\t");
                    }
        }

        public void int mt_Recur(ref int[] ia_Arr ,int i_X){
            if (i_X <= 1){
                return;
            }
            mt_Recur(ref ia_Arr, i_X - 1);
            int i_Max = ia_Arr[i_X];
            for (int i_ct<= 1; i_ct <= i_X/2; i_ct++){
                int i_sum ia_Arr[i_ct] + ia_Arr[i_X - i_ct];
                if (i_sum > i_Max){
                    i_Max = i_sum;
                }
            }
            ia_Arr[i_X] = i_Max;
        }
    }
}