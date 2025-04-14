import { AnimalInterface } from "@/app/Interfaces/animalinterface";
import AnimalCard from "../Animal Card/animalcard";
import styles from "./query.module.css"


export default async function Query({ searchParams, data}: {searchParams: Promise<{query: string | undefined; filter: string | undefined}>, data: AnimalInterface[]}) {
    const query = (await searchParams)?.query || '';
    const filter = (await searchParams)?.filter || '';

    const sortyByFilter: AnimalInterface[] = [];

    const searchQuery = Array.isArray(data) ? 
    (sortyByFilter.length === 0 ?
        data.filter((item) => {
            return item.name.toLowerCase().includes(query.toLowerCase());
        }) :
        sortyByFilter.filter((item) => {
            return item.name.toLowerCase().includes(query.toLowerCase());
        })): [];

  return (
    <section className={styles.queryWrapper}> 
        {searchQuery.length === 0 ? <p className={styles.queryP}>No animals matched the search term.</p> : searchQuery.map((item) => <AnimalCard key={item.id} data={item}/>)}
    </section>
  )
}
