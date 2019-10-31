using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public int Data { get; set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(int nodeData)
        {
            Data = nodeData;
            LeftNode = RightNode = null;
        }

        public void Insert(int insertValue)
        {
            if(insertValue < Data)
            {
                if (LeftNode == null)
                    LeftNode = new TreeNode(insertValue);
                else
                    LeftNode.Insert(insertValue);
            }
            else if(insertValue > Data)
            {
                if (RightNode == null)
                    RightNode = new TreeNode(insertValue);
                else
                    RightNode.Insert(insertValue);
            }
        }
    }
}
