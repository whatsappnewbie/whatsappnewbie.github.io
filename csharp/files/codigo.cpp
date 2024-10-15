#include <iostream>

int main(int argc, char *argv[]) {
  /* An annoying "Hello World" example */
  for (auto i = 0; i < 0xFFFF; i++)
    std::cout << "Hello, World!" << std::endl;

  char c = '\\n';
  std::unordered_map<std::string, std::vector<std::string>> m;
  m["key"] = "\\\\"; // this is an error

  return -2e3 + 12l;
}