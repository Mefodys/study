class Node:
    def __init__(self, data = None, next = None):
        self.data = data
        self.next = next

class LinkedList:
    def __init__(self):
        self.head = None

    def insert_at_beginning(self, data):
        node = Node(data, self.head)
        self.head = node

    def printNode(self):
        if self.head is None:
            print('Linked list is empty')
            return 0

        itr = self.head
        lstr = ''

        while itr:
            lstr+= str(itr.data) + '-->'
            itr = itr.next

        print(lstr)

    def insert_at_end(self, data):
        if self.head is None:
            self.head = Node(data, None)

        itr = self.head
        while itr.next:
            itr = itr.next

        itr.next = Node(data, None)

    def insers_values(self, data_list):
        self.head = None
        for data in data_list:
            self.insert_at_end(data)

    def get_length(self):
        count = 0
        itr = self.head
        while itr:
            count += 1
            itr = itr.next
        return count

    def remove_at_index(self, index):
        if index<0 or index>=self.get_length():
            raise Exception ('Invalid index')

        if index ==0:
            self.head = self.head.next
            return 1

        count = 0
        itr = self.head
        while itr:
            if count == index -1:
                itr.next = itr.next.next
                break
            itr = itr.next
            count +=1

    def insert_at_index(self, index, data):
        if index < 0 or index >= self.get_length():
            raise Exception('Invalid index')

        if index ==0:
            self.insert_at_beginning(data)
            return 1

        count = 0
        itr = self.head
        while itr:
            if count == index-1:
                node = Node(data, itr.next)
                itr.next = node
                break


            itr = itr.next
            count +=1

if __name__ == '__main__':
    l1 = LinkedList()
    l1.insert_at_beginning(5)
    l1.insert_at_beginning(10)
    l1.printNode()
    l1.insert_at_end(999)
    l1.printNode()
    l1.insert_at_beginning(1)
    l1.printNode()
    print(l1.get_length())
    l1.remove_at_index(2)
    l1.printNode()
    print(l1.get_length())
    l1.insert_at_index(1, 99)
    l1.printNode()