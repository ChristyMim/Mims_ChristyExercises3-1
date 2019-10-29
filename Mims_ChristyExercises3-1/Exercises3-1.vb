'Program Name: Exercises 3-1
'Programmer: Christy Mims
'Date: 1/20/17
'Description: This program allows the user to see the results of the problems in Exercise 
'3-1: 67, 68, 69, 70, 72, 73, 75, 76, 77, 78, 79, 80.  The program displays the results 
'through the use of buttons and a list box.
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'This button allows the user to close the program.
    End Sub

    Private Sub btnExercise67_Click(sender As Object, e As EventArgs) Handles btnExercise67.Click
        Dim revenue As Decimal, costs As Decimal, Profit As Decimal
        revenue = 98456
        costs = 45000
        Profit = revenue - costs
        lstResults.Items.Clear()
        lstResults.Items.Add(Profit)
        'This procedure displays the results of profits made and performs the calculations
        'for the user.
    End Sub

    Private Sub btnExercise68_Click(sender As Object, e As EventArgs) Handles btnExercise68.Click
        Dim costPerShare As Decimal, numberOfShares As Decimal, amount As Decimal
        costPerShare = 25.625D
        numberOfShares = 400
        amount = costPerShare * numberOfShares
        lstResults.Items.Clear()
        lstResults.Items.Add(amount)
        'This procedure calculates the data for the user and displays the answer in a list
        'box.
    End Sub

    Private Sub btnExercise69_Click(sender As Object, e As EventArgs) Handles btnExercise69.Click
        Dim price As Decimal, discountPercent As Decimal, markdown As Decimal
        price = 19.95D
        discountPercent = 30
        markdown = (discountPercent / 100) * price
        price = price - markdown
        lstResults.Items.Clear()
        lstResults.Items.Add(Math.Round(price, 2))
        'This procedure calculates a markdown price for the user and displays the answer
        'in a list box.
    End Sub

    Private Sub btnExercise70_Click(sender As Object, e As EventArgs) Handles btnExercise70.Click
        Dim fixedCosts As Decimal, pricePerUnit As Decimal, costPerUnit As Decimal, breakEvenPoint As Decimal
        fixedCosts = 5000
        pricePerUnit = 8
        costPerUnit = 6
        breakEvenPoint = fixedCosts / (pricePerUnit - costPerUnit)
        lstResults.Items.Clear()
        lstResults.Items.Add(breakEvenPoint)
        'This procedure calculates and displays the results of the data in a list box for 
        'the user.
    End Sub

    Private Sub btnExercise72_Click(sender As Object, e As EventArgs) Handles btnExercise72.Click
        Dim balance As Decimal
        balance = 100
        balance = balance * 0.05D + 100
        balance = balance * 0.05D + 100
        balance = balance * 0.05D
        lstResults.Items.Clear()
        lstResults.Items.Add(Math.Round(balance, 2))
        'Through this procedure the data included in the code is calculated and displayed
        'in a list box for the user.
    End Sub

    Private Sub btnExercise73_Click(sender As Object, e As EventArgs) Handles btnExercise73.Click
        Dim purchasePrice As Decimal, sellingPrice As Decimal, markup As Decimal, percentageMarkup As Decimal
        purchasePrice = 215.5D
        sellingPrice = 644.99D
        markup = sellingPrice - purchasePrice
        percentageMarkup = 100 * (markup / purchasePrice)
        lstResults.Items.Clear()
        lstResults.Items.Add(percentageMarkup)
        'The data provided is calculated and then displayed in a list box for the user.
    End Sub

    Private Sub btnExercise75_Click(sender As Object, e As EventArgs) Handles btnExercise75.Click
        Dim corn As Decimal, farm As Decimal, tonsOfCorn As Decimal
        corn = 18
        farm = 30
        tonsOfCorn = corn * farm
        lstResults.Items.Clear()
        lstResults.Items.Add(tonsOfCorn)
        'This procedure allows data to be computed and then displayed in a display box for
        'the user.
    End Sub

    Private Sub btnExercise76_Click(sender As Object, e As EventArgs) Handles btnExercise76.Click
        Dim velocity As Decimal, height As Decimal, time As Decimal
        velocity = 50
        height = 5
        time = 3
        height = (-16 * time ^ 2) + (velocity * time) + height
        lstResults.Items.Clear()
        lstResults.Items.Add(height)
        'This procedure calculates and displays the data in a list box for the user.
    End Sub

    Private Sub btnExercise77_Click(sender As Object, e As EventArgs) Handles btnExercise77.Click
        Dim time As Decimal, speed As Decimal, distance As Decimal
        time = 5
        distance = 233
        speed = distance / time
        lstResults.Items.Clear()
        lstResults.Items.Add(speed)
        'This procedure allows the user to see the data after it has been calculated.
    End Sub

    Private Sub btnExercise78_Click(sender As Object, e As EventArgs) Handles btnExercise78.Click
        Dim odometerStart As Decimal, odometerEnd As Decimal, gallons As Decimal, milesPerGallon As Decimal
        odometerStart = 23352
        odometerEnd = 23695
        gallons = 14
        milesPerGallon = (odometerEnd - odometerStart) / 14
        lstResults.Items.Clear()
        lstResults.Items.Add(milesPerGallon)
        'This procedure calculates the data for the user then displays in a list box.
    End Sub

    Private Sub btnExercise79_Click(sender As Object, e As EventArgs) Handles btnExercise79.Click
        Dim gallonsOfWater As Decimal, population As Decimal, year As Decimal, endOfYear As Decimal
        gallonsOfWater = 1600
        population = 315000000
        year = 365
        endOfYear = population * gallonsOfWater * year
        lstResults.Items.Clear()
        lstResults.Items.Add(endOfYear)
        'This procedure allows the user to see data displayed in a list box after the data
        'has been calculated.
    End Sub

    Private Sub btnExercise80_Click(sender As Object, e As EventArgs) Handles btnExercise80.Click
        Dim pizzaPerSecond As Decimal, day As Decimal, minute As Decimal, hour As Decimal, slicesPerDay As Decimal
        pizzaPerSecond = 350
        minute = 60
        hour = 60
        day = 24
        slicesPerDay = pizzaPerSecond * minute * hour * day
        lstResults.Items.Clear()
        lstResults.Items.Add(slicesPerDay)
        'This procedure calculates and displays the data in a list box for the user.
    End Sub
End Class
