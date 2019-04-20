import java.util.*;

// THIS IS THE ONLY FILE WHICH NEEDS TO BE ALTERED

class HW7Sol {

    // change the size of the tree here
    private static final int treeSize = 9;

    public static void main(String[] args) {
        NewTreeNode<Integer> root = NewBinaryTree.BuildTreeRecursively(0, treeSize);
        Stack<NewTreeNode<Integer>> s = new Stack<NewTreeNode<Integer>>();
        s.push(root);
        Queue<NewTreeNode<Integer>> q = new LinkedList<NewTreeNode<Integer>>();
        q.add(root);

        // DFS
        System.out.println("-----------------");
        System.out.println("DFS");
        System.out.println("-----------------");
        // TODO: stack or queue as a parameter here???
        HW7Sol.DFS();

        // BFS
        System.out.println("-----------------");
        System.out.println("BFS");
        System.out.println("-----------------");
        // TODO: stack or queue as a parameter here???
        HW7Sol.BFS();
    }

    // TODO: implement DFS
    // Do you use a stack or a queue as a parameter here???
    public static void DFS() {

    }

    // TODO: implement BFS
    // Do you use a stack or a queue as a parameter here???
    public static void BFS() {

    }
}