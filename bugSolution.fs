let x = 0
let y = 0

let rec loop x y =
    if x < 10 then
        loop (x + 1) y
    else if y < 5 then
        loop 0 (y + 1)
    else
        x, y

let finalX, finalY = loop x y
printf "%d %d" finalX finalY