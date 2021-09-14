using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewChinese2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2.Tests
{
    [TestClass()]
    public class T35_CopyRandomListTests
    {
        [TestMethod()]
        public void CopyRandomListTest()
        {
            var input = new int?[5,2] { { 7, null }, { 13, 0 }, { 11, 4 }, { 10, 2 }, { 1, 0 } };

            Node node = null;
            Node head = null;

            node = new Node(input[0, 0]);
            for (int i = 1; i < 5; i++)
            {
                node.next = new Node(input[i, 0]);
                if (head == null)
                    head = node;
                node = node.next;
            }

            node = head;
            for (int i = 0; i < 5; i++)
            {
                var value = input[i, 1];
                if(value != null)
                {
                    Node random = head;
                    for (int j = 0; j < value; j++)
                    {
                        random = random.next;
                    }
                    node.random = random;
                }
                node = node.next;
            }

            T35_CopyRandomList.CopyRandomList(head);
        }
    }
}