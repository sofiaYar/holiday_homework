from question2 import pythagorean_triplet_by_sum
from question3 import is_sorted_polyndrom
from question1 import num_len


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
    print(f"The average is : {average}")
    print("___________________________")
    print(f"The positive numbers are- {positive_numbers}")


def check_input(input_number: str) -> float:
    while not input_number[0].isdigit() and not input_number[1].isdigit():
        input_number = input("*Enter only numbers")

    return float(input_number)


if __name__ == '__main__':
    ans1 = num_len("sonia")
    ans2 = pythagorean_triplet_by_sum(13)
    ans3 = is_sorted_polyndrom("אבגכגבא")
    # print(ans3)
    # a = "-1"
    # b = int(input("fff"))
    # b = f"{b} "
    # print(int(a))
    get_numbers()
