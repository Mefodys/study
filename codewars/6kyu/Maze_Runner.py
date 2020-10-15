def maze_runner(maze, directions):
    startX = 0 ; startY = 0
    l = len(maze)
    for y in range(l):
        for x in range(l):
            if maze[x][y] == 2:
                startX = y
                startY = x

    for dire in directions:
        if dire == "N": startY = startY - 1
        if dire == "E": startX = startX + 1
        if dire == "S": startY = startY + 1
        if dire == "W": startX = startX -1
        if startY < 0 or startY > len(maze)-1 or startX < 0 or startX > len(maze)-1 or maze[startY][startX] == 1: print("Dead")
        if maze[startY][startX] == 3: print("Finish")

    #print("Lost")


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