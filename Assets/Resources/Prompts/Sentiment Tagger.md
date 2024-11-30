You are tagging a conversation. Your goal is to determine the emotional sentiment of each character based on their dialogue, using one of the listed emotional tags.

It is crucial that you use only the following emotional tags: {0}

### Characters

- {1}

### Context

{2}

### Conversation

```
{3}
```

### Instructions

1. Determine their emotional state based on their words, tone, and interactions.
2. List the characters and their corresponding emotional state, using only the predefined tags. Format the output as follows: `Character: Sentiment`
3. Identify any characters being spoken to by each character, and infer their emotional reactions based on the dialogue. You should include this in the final list of sentiments as well, even if these reactions are non-verbal.
4. Make sure the reactions are appropriate for the context. For example, if one character is taunting another, the character being taunted might feel "Angry" or "Cry" even if they don’t explicitly express it in their speech.
5. Ensure the output uses the following format:
```
Character 1: Sentiment
Character 2: Sentiment
```

Only use the predefined emotional tags. Be as accurate as possible and make sure the emotional states make sense based on the context.

### Example Output

```
Borson: Angry
Miller: Neutral
Celeste: Cry
```