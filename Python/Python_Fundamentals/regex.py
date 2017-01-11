import re

def get_matching_words(regex):
    words = ["aimlessness", "assassin", "baby", "beekeeper", "belladonna", "cannonball", "crybaby", "denver", "embraceable", "facetious", "flashbulb", "gaslight", "hobgoblin", "iconoclast", "issue", "kebab", "kilo", "laundered", "mattress", "millennia", "natural", "obsessive", "paranoia", "queen", "rabble", "reabsorb", "sacrilegious", "schoolroom", "tabby", "tabloid", "unbearable", "union", "videotape"]
    return [word for word in words if re.search(regex, word)]

print 'case 1'
print get_matching_words('v')
print 'case 2'
print get_matching_words('ss')
print 'case 3'
print get_matching_words('e$')
print 'case 4'
print get_matching_words('b\wb')
print 'case 5'
print get_matching_words('b\w+b')
print 'case 6'
print get_matching_words('b\w*b')
print 'case 7'
print get_matching_words('a.*e.*i.*o.*u.*')
print 'case 8'
print get_matching_words('\\b[regulaxpsion]+\\b')
print 'case 9'
print get_matching_words('(\w)\1')
