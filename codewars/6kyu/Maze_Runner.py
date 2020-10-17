# def maze_runner(maze, directions):
#     startX = 0 ; startY = 0
#     l = len(maze)
#     for y in range(l):
#         for x in range(l):
#             if maze[x][y] == 2:
#                 startX = y
#                 startY = x
#
#     for dire in directions:
#         if dire == "N": startY = startY - 1
#         if dire == "E": startX = startX + 1
#         if dire == "S": startY = startY + 1
#         if dire == "W": startX = startX -1
#         if startY < 0 or startY > len(maze)-1 or startX < 0 or startX > len(maze)-1 or maze[startY][startX] == 1: print("Dead")
#         if maze[startY][startX] == 3: print("Finish")
#
#     #print("Lost")
#




##
def maze_runner(maze, directions):
    n = len(maze)

    # find start point
    for i in range(n):
        x = maze[i]
        if 2 in maze[i]:
            row = i
            col = maze[row].index(2)
            break

    # follow directions
    for step in directions:
        if step == "N":
            row -= 1
        elif step == "S":
            row += 1
        elif step == "E":
            col += 1
        elif step == "W":
            col -= 1

        # check the result
        if row < 0 or col < 0 or row == n or col == n or maze[row][col] == 1:
            print("Dead")
        elif maze[row][col] == 3:
            print("Finish")

    #return "Lost"

maze = [[1,1,1,1,1,1,1],
        [1,0,0,0,0,0,3],
        [1,0,1,0,1,0,1],
        [0,0,1,0,0,0,1],
        [1,0,1,0,1,0,1],
        [1,0,0,0,0,0,1],
        [1,2,1,0,1,0,1]]

maze_runner(maze,["N","N","N","N","N","E","E","E","E","E"])   # , "Finish")
#maze_runner(maze,["N","N","N","N","N","E","E","S","S","E","E","N","N","E"]) #  , "Finish")
#maze_runner(maze,["N","N","N","N","N","E","E","E","E","E","W","W"])   #, "Finish")