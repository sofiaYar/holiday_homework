import numpy as np
import matplotlib.pyplot as plt
from scipy.stats import pearsonr


def get_numbers():
    input_number = input(f"Enter a number: \n*When u finished enter -1 \n")
    input_number = f"{input_number} "
    input_number = check_input(input_number)
    numbers_list = []
    sum_of_numbers = 0
    positive_numbers = []
    count_of_numbers = 0
    while input_number != -1:
        if input_number > 0:
            positive_numbers.append(input_number)
        count_of_numbers += 1
        sum_of_numbers += input_number
        numbers_list.append(input_number)
        input_number = input(f"Enter a number: \n*When u finished enter -1 \n")
        input_number = check_input(input_number)

    average = sum_of_numbers / count_of_numbers
    copy_of_the_list = create_same_list(numbers_list)
    numbers_list.sort()
    numbers_list = remove_duplicates(numbers_list)
    positive_numbers = remove_duplicates(positive_numbers)

    print(f"The average is : {average}")
    print("________________")
    print(f"The positive numbers are- {positive_numbers}")
    print("__________________________________")
    print(f"The sorted list of the numbers is- {numbers_list}")
    create_plot = input("Do you want to create a plot of the numbers? (Y/N) ")
    if create_plot.lower() == 'yes':
        numbers_graph(copy_of_the_list)


def numbers_graph(numbers_list):
    indices = np.arange(len(numbers_list))
    correlation, _ = pearsonr(indices, numbers_list)
    print(f"Pearson correlation: {correlation}")

    plt.scatter(indices, numbers_list)

    slope, intercept = np.polyfit(indices, numbers_list, 1)
    plt.plot(indices, slope * indices + intercept)

    plt.xlabel('index')
    plt.ylabel('value')
    plt.title('graph of the entered numbers')
    plt.show()


def create_same_list(original_list: list) -> list:
    answer = []
    for i in original_list:
        answer.append(i)
    return answer


def remove_duplicates(input_list: list) -> list:
    temp = []
    for x in input_list:
        if x not in temp:
            temp.append(x)
    return temp


def input_is_empty(input_number) -> str:
    while input_number == " " or input_number == "":
        input_number = input("You cant leave the field empty, enter something \n")
    return f"{input_number} "


def check_input(input_number:str) -> float:
    input_number = input_is_empty(input_number)
    while not input_number[0].isdigit() and not input_number[1].isdigit():
        input_number = input("*Enter only numbers")
        input_number = input_is_empty(input_number)

    return float(input_number)
