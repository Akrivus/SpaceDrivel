### **1. Workflow Overview**

#### **Key Phases:**

1. **User Idea Input:** A short, creative scene idea provided by you as the seed for the entire workflow.
2. **Storyboarder Prompt:** Generates specific character contexts and aligns them with the overarching narrative.
3. **Dialogue Agent Prompt:** Produces conversational responses for each character based on their individual contexts, memories, and goals.
4. **Sentiment Tagging:** Assigns emotional tone and mood to the generated responses for use in animations, gestures, or post-processing.

---

### **2. Detailed Breakdown of Each Phase**

#### **A. User Idea Input (Seed)**

- **Purpose:** Provides the seed for the scene and establishes what the characters should focus on.
- **Format:** A short, descriptive prompt.
- **Example Input:**
    - _"Miller mumbles about nihilism and the meaning of man as Celeste pours him some of the Captain's whiskey, suspecting he knows her secret."_

---

#### **B. Storyboarder Prompt**

- **Purpose:** Translates the user-generated idea into **character-specific goals and motivations**, aligning them with the current narrative state.
    
- **Inputs:**
    
    - The **user idea** seed.
    - The **current narrative state** (e.g., timeline, unresolved story arcs).
    - Each character's **memories, notes, and personality context**.
- **Output Format:**
    
    - A new **context prompt** for each character.
    - Describes their mental/emotional state and immediate goals.
- **Example Input for Storyboarder:**
    
    plaintext
    
    Copy code
    
    `Idea: Miller mumbles about nihilism and the meaning of man as Celeste pours him some of the Captain's whiskey, suspecting he knows her secret.   Narrative State: Celeste is worried about being discovered. Miller is protecting her but unsure why.   Memories: Miller covered for Celeste with Julie earlier. Celeste suspects Miller knows she was at the crime scene.`  
    
- **Example Output:**
    
    plaintext
    
    Copy code
    
    `Miller: Your head is killing you. A drink would be nice. Celeste seems troubled. You might ask her what's on her mind after she pours you that whiskey.   Celeste: Just as you left the crime scene, you and Miller locked eyes. Does he know? When Julie asked where I was, Miller said I was in the engine bay. Why did he do that?`  
    

---

#### **C. Dialogue Agent Prompt**

- **Purpose:** Generates realistic dialogue based on each character’s context, memories, and personality.
    
- **Inputs:**
    
    - The **conversation so far** (what characters have said).
    - Each character’s **current context** (from Storyboarder).
    - **Instructions** for structuring the output into Thoughts, Notes, and Talk.
- **Output Format:**
    
    plaintext
    
    Copy code
    
    `Thoughts: (Internal reasoning or emotions.)  Notes: (New observations or assumptions.)  Say: (What the character says out loud.)`
    
- **Example Input for Dialogue Agent:**
    
    plaintext
    
    Copy code
    
    `Conversation So Far:   Celeste: What did you see?    Miller Context: Your head is killing you. A drink would be nice. Celeste seems troubled. You might ask her what's on her mind after she pours you that whiskey.`  
    
- **Example Output:**
    
    plaintext
    
    Copy code
    
    `Thoughts:   I'll think about murder mystery after I've had a drink and a heart-to-heart with Celeste.    Notes:   Celeste has whiskey.    Say:   Don't mind if I do!`  
    

---

#### **D. Sentiment Tagging**

- **Purpose:** Analyzes the emotional tone of each piece of dialogue for use in animations, gestures, or post-processing.
    
- **Process:**
    
    - Each response is run through a **sentiment analyzer** to detect the emotional tone (e.g., angry, fearful, happy).
    - Sentiments are tagged for both **qualitative** (angry, calm, curious) and **quantitative** (strength of the emotion) purposes.
- **Output Format:**
    
    - Sentiment label (e.g., angry, calm).
    - Sentiment score (e.g., -1 to +1 or a percentage).
- **Example:**
    
    plaintext
    
    Copy code
    
    `Dialogue: "Don't mind if I do!"   Sentiment:   - Label: Neutral.   - Score: 0.2 (slightly positive).`  
    
- **Integration:** The sentiment tags are fed back into the system to trigger **expressions, poses, and gestures.**
    

---

### **3. Enhancements and Recommendations**

#### **A. Streamlining Character Context Updates**

- Ensure the **Storyboarder Prompt** updates each character’s context with:
    - **Evolving goals:** What the character wants now, based on the scene.
    - **Revised relationships:** How interactions with others affect their perceptions.
    - **Scene-specific focus:** Highlight any immediate concerns tied to the user’s idea.

#### **B. Adding Dynamic Goal Adjustments**

- Characters could **revise their goals** mid-scene based on dialogue. For example:
    - Celeste might shift from defensive to curious if Miller doesn’t act suspicious.

#### **C. Improving Sentiment Integration**

- Use sentiment tags to:
    - **Trigger animations and expressions:** Directly map emotions to gestures and poses.
    - **Adjust tone in dialogue:** Characters with high anger might speak tersely, while those with curiosity might use probing questions.

#### **D. Ensuring Emergent Storytelling**

- Allow **Notes** to accumulate and subtly influence future Storyboarder Prompts. This creates a sense of continuity and emergent storytelling.
- Example: If Miller consistently notes Celeste’s anxiety, future prompts might instruct him to ask her directly about it.

---

### **4. Example Workflow in Action**

#### **Step 1: User Idea Input**

- _"Miller mumbles about nihilism and the meaning of man as Celeste pours him some of the Captain's whiskey, suspecting he knows her secret."_

#### **Step 2: Storyboarder Prompt**

- Input: Narrative State, Memories, Idea.
- Output: Character-specific contexts.
    
    plaintext
    
    Copy code
    
    `Miller: Your head is killing you. A drink would be nice. Celeste seems troubled. You might ask her what's on her mind after she pours you that whiskey.   Celeste: Just as you left the crime scene, you and Miller locked eyes. Does he know? When Julie asked where I was, Miller said I was in the engine bay. Why did he do that?`  
    

#### **Step 3: Dialogue Agent Prompt**

- Input: Conversation so far + Character Contexts.
- Output: Dialogue and internal reasoning.
    
    plaintext
    
    Copy code
    
    `Thoughts:   I'll think about murder mystery after I've had a drink and a heart-to-heart with Celeste.    Notes:   Celeste has whiskey.    Say:   Don't mind if I do!`  
    

#### **Step 4: Sentiment Tagging**

- Input: Dialogue from all characters.
- Output: Sentiments for animation/gestures.
    
    plaintext
    
    Copy code
    
    `Dialogue: "Don't mind if I do!"   Sentiment: Neutral, Score: 0.2.`  
    

---

### **5. Final Thoughts**

Your workflow strikes a balance between **user-driven creativity** and **autonomous character development.** Breaking it into clear phases with structured outputs ensures that:

- Characters stay aligned with the overarching narrative.
- Dialogue feels organic and grounded in individual motivations.
- Sentiment analysis enhances immersion with matching gestures and emotions.