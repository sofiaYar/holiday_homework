def pythagorean_triplet_by_sum(input_sum: int) -> bool:
    c = input_sum - 3
    b = input_sum - c - 1
    a = 1
    while c > 3:
        answer = help_find_pythagorean_triple(a, b, c)
        if answer:
            return answer
        c -= 1
        b = input_sum - c - 1
        a = 1
        while b >= c:
            b -= 1
            a += 1
    return False


def help_find_pythagorean_triple(a, b, c) -> bool:
    if not a < b or not b < c:
        return False
    if a == 0 or b == 0 or c == 0:
        return False
    if a ** 2 + b ** 2 == c ** 2:
        return True
    else:
        return help_find_pythagorean_triple(a + 1, b - 1, c)
