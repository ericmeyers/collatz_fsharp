open XPlot.Plotly

// yes the sequence values can bust int32
let rec collatz_length (n: int64)  =
    if n = 1            then 1
    elif (n % 2L) = 0L  then collatz_length (n / 2L) + 1
    else                     collatz_length (3L * n + 1L) + 1


//let xs = [ 1L .. 5000000L ]
let xs = [ 1L .. 500000L ]
let ys = List.map collatz_length  xs

let trace  =
    Scatter(
      x = xs,
      y = ys,
      mode = "markers"
    )
trace |> Chart.Plot |> Chart.Show
