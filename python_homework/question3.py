def is_sorted_polyndrom(input_word: str) -> bool:
    word_length = len(input_word)
    word_length_in_half = word_length // 2
    first_word_part = input_word[0: word_length_in_half]
    second_word_part = input_word[word_length_in_half + 1: word_length]
    if first_word_part != second_word_part[::-1]:
        print("the input word is not polyndrom")
        return False
    return is_sorted(first_word_part)


def is_sorted(first_part: str) -> bool:
    previous_char_num = ord(first_part[0]) - 1
    previous_char = chr(previous_char_num)

    for char in first_part:
        a = ord(char)
        b = ord(previous_char)
        if ord(char) != ord(previous_char) + 1:
            return False
        previous_char = char
    return True
