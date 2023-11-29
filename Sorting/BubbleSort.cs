using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{

    public class BubbleSort : SortingAlgorithm<int>
    {
        public override int[] Sort(int[] data)
        {
            for (int i = 0; i < data.Length; i++) //Pass rounds
            {
                for (int j = 1; j < data.Length; j++) // j đi từ 1, ta so sánh với j-1
                    if (data[j] < data[j - 1])
                    {
                        int temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
            }
            return data;

            #region Tối ưu số lượt pass
            //Nếu trong một lượt pass ta không thấy có thao tác swap, nghĩa là mảng đã được sắp xếp đúng thứ tự, vậy các lượt pass tiếp theo không cần thiết nữa.
            //Khai báo một biến isSorted với giá trị false. [1]
            //Ở mỗi lượt pass, trước khi so sánh 2 phần tử với nhau, ta kiểm tra giá trị isSorted, nếu = false thì tiếp tục lượt pass, nếu isSorted thì break luôn vòng loop các lượt pass. [2]
            //Trường hợp không break, ta giả định là mảng đã được sắp xếp rồi, isSorted = true. Nếu có bất kì thao tác swap nào trong pass đó, thì gán lại isSorted = false. [3]

            //bool isSorted = false; // [1]
            //for (int i = 0; i < data.Length; i++) //Pass round
            //{
            //    if (isSorted) break; // [2]
            //    isSorted = true; // [3]
            //    for (int j = 1; j < data.Length; j++) // j đi từ 1, ta so sánh với j-1
            //        if (data[j] < data[j - 1])
            //        {
            //            int temp = data[j];
            //            data[j] = data[j - 1];
            //            data[j - 1] = temp;
            //            isSorted = false; // [3]
            //        }
            //}
            #endregion

            #region Tối ưu số lượt so sánh trong mỗi pass
            //bool isSorted = false; // [1]
            //for (int i = 0; i < data.Length; i++) //Pass round
            //{
            //    if (isSorted) break;
            //    isSorted = true;
            //    for (int j = 1; j < data.Length - i; j++) // Ở đây j đi đến data.Length -1 để tối ưu, không phải so sánh với các item đã đúng vị trí ở cuối mảng
            //        if (data[j] < data[j - 1])
            //        {
            //            int temp = data[j];
            //            data[j] = data[j - 1];
            //            data[j - 1] = temp;
            //            isSorted = false;
            //        }
            //}
            //return data;
            #endregion
        }
    }
}
