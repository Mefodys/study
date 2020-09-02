class Point1:

    def __init__(self, coord_x = 0, coord_y = 0):
        self.x = coord_x
        self.y = coord_y

    def move_to(self, new_x, new_y):
        self.x = new_x
        self.y = new_y

    def go_home (self):
        self.x = 0
        self.y = 0


#===

class Point2:

    def __init__(self, coord_x = 0, coord_y = 0):
        self.move_to (coord_x, coord_y)
        
    def move_to(self, new_x, new_y):
        self.x = new_x
        self.y = new_y

    def go_home (self):
        self.move_to(0,0)

    def print_point(self):
        print (f"Точка с координатами ({self.x}, {self.y})")
        

p1 = Point2(5)
print(p1.x, p1.y)

p1 = Point2(5,7)
p1.print_point()

p1.go_home()
p1.print_point()

p1.print_point()