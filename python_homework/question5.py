import mpmath as math


def reverse_n_pi_digits(input_number: int) -> str:
    digits_pi = str(math.pi).replace(".", "")
    return digits_pi[:input_number][::-1]
